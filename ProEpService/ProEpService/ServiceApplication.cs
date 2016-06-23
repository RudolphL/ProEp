using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ProEpService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceApplication : ILogin, IMessage, IPortal
    {
        #region fields

        private List<Post> posts;
        private List<User> users;

        static Action<List<Post>> eventUpdatePosts = delegate { };
        private Action update_message = delegate { };

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public ServiceApplication()
        {
            DBHelper dbHelper = new DBHelper();
            this.users = new List<User>();
            this.posts = dbHelper.GetAllPosts();
        }

        #region Login

        /// <summary>
        /// User tries to login. Returns a boolean, true if the user can log in, and false if the user is not allowed to log in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.CheckLogin(username, password);
        }

        #endregion

        #region Recover Password

        /// <summary>
        /// User tries to recover password. Returns true if successful, and false if not found.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool RecoverPassword(string email)
        {
            DBHelper dbhelper = new DBHelper();
            String[] information = dbhelper.GetPrivateCredentials(email);
            //Arrayposition: 0 username, 1 name, 2 password

            if (information != null)
            {
                try
                {
                    String to = email;
                    String subject = "User information";
                    String body = "Dear " + information[1] + ",\n\nYour information:\n\nUsername: " 
                        + information[0] + "\nPassword: " + information[2] + "\n\nKind regards,\nProEp Group D Team";
                    String smtp = "smtp.gmail.com";
                    String username = "proepgroupd@gmail.com";
                    String password = "proep123";
                    MailMessage mail = new MailMessage(username, to, subject, body);
                    SmtpClient client = new SmtpClient(smtp);
                    client.Port = 587; //465 - 587
                    client.Credentials = new NetworkCredential(username, password);
                    client.EnableSsl = true;
                    client.Send(mail);

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Register
        /// <summary>
        /// User tries to register, create a user.
        /// Return type int: different meaning depending on the int value.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="city"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int Register(string username, string password, string name, string city, string email)
        {
            /* 
             Return -1 : Exception
             Return 0 : User exist
             Return 1 : Email exist
             Return 2 : User created
             */            
            DBHelper dbHelper = new DBHelper();
            return dbHelper.CreateUser(username, password, name, city, email);
        }

        #endregion

        #region Post

        /// <summary>
        /// Add a post to the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="price"></param>
        /// <param name="isbn"></param>
        /// <param name="publisher"></param>
        /// <param name="bookCondition"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="place"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public void AddPost(string name, string author, double price, string isbn, string publisher, string bookCondition, string description, string title, string place, string username)
        {
            Book book = new Book(name, author, price, isbn, publisher, bookCondition);
            Post post = new Post(description, title, book, place);
            DBHelper dbHelper = new DBHelper();

            dbHelper.CreatePost(post, username);
            this.posts.Add(post);

            // Trigger event for all users.
            eventUpdatePosts(this.posts);
        }

        #endregion

        #region Message methods

        /// <summary>
        /// This method will unsubscribe the client from getting notify by the callback of IUpdateMessage
        /// </summary>
        public void UpdateMessageUnsubcribe()
        {
            update_message -= OperationContext.Current.GetCallbackChannel<IUpdateMessageCallback>().UpdateMessage;
        }

        /// <summary>
        /// This method will subcribe the client to receiver a trigger from the client( a call back) with IUpdateMessage 
        /// </summary>
        public void UpdateMessageSubscribe()
        {
            update_message += OperationContext.Current.GetCallbackChannel<IUpdateMessageCallback>().UpdateMessage;
        }

        /// <summary>
        /// This method will send the message text to the database and then notify the client (refresh)
        /// The message will be send as a Message type object which contain : sender, receiver, id and text.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public void SendMessage(Message message)
        {
            DBHelper dbHelper = new DBHelper();

            if (dbHelper.InsertMessage(message) == true)
            {
                update_message();
            }         
        }

        /// <summary>
        /// This method will get the ListOfPerson that the user have chated with before.
        /// </summary>
        /// <param name="user"> the username of the current user</param>
        /// <returns></returns>
        public List<string> GetListOfPersonOnMessage(string username)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.GetListOfPersonOnMessage(username);
        }

        /// <summary>
        /// This method will get the ListOfMessage( return a List of type Message) 
        /// by searching through the database and then find the message 
        /// with sender and user like parameters had declared
        /// </summary>
        /// <param name="sender_username">user name of sender</param>
        /// <param name="receiver_username">user name of receiver</param>
        /// <returns></returns>
        public List<Message> GetListOfMessage(string sender_username, string receiver_username)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.GetMessages(sender_username, receiver_username);
        }

        #endregion

        #region Portal methods

        /// <summary>
        /// User signs in, and subscribes to the events.
        /// </summary>
        /// <param name="username"></param>
        public void SignIn(string username)
        {
            User currentUser = new User(username);
            currentUser.UserPortalCallback = OperationContext.Current.GetCallbackChannel<IPortalCallback>();
            this.users.Add(currentUser);

            //Subscribing to events.
            eventUpdatePosts += currentUser.UserPortalCallback.NewPostAdded;
        }

        /// <summary>
        /// User signs out, and unsubscribes to the events.
        /// </summary>
        /// <param name="username"></param>
        public void SignOut(string username)
        {
            User currentUser = null;

            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    currentUser = user;
                }
            }

            //Unsubscribing to events.
            eventUpdatePosts -= currentUser.UserPortalCallback.NewPostAdded;
        }

        public List<Post> GetPosts()
        {
            return this.posts;
        }

        #endregion
    }
}
