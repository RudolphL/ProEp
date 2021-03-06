﻿using System;
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
    public class ServiceApplication : ILogin, IPortal, IViewer, IProfile, IPersonal, ICommunication

    {
        #region fields

        private List<Post> posts;
        private List<User> users;
        private List<User> viewers;

        static Action<List<Post>> eventUpdatePosts = delegate { };
        static Action<List<Post>> eventViewerUpdatePosts = delegate { };

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public ServiceApplication()
        {
            DBHelper dbHelper = new DBHelper();
            this.users = new List<User>();
            this.viewers = new List<User>();
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

            int postId, bookId;

            dbHelper.CreatePost(post, username, out postId, out bookId);

            // Assigning the postid and bookid and seller
            post.PostId = postId;
            post.Book.BookId = bookId;
            post.Seller = username;
            this.posts.Add(post);

            // Trigger event for all users.
            eventUpdatePosts(this.posts);
            // Trigger event for all viewers.
            eventViewerUpdatePosts(this.posts);
        }

        /// <summary>
        /// Get a post in the list by the post id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Post GetPostById(int id)
        {
            foreach (Post post in this.posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }
            return null;
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
            currentUser.UserNewPostAddedCallback = OperationContext.Current.GetCallbackChannel<IPortalCallback>();
            this.users.Add(currentUser);

            //Subscribing to events.
            eventUpdatePosts += currentUser.UserNewPostAddedCallback.NewPostAdded;
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

            if (currentUser != null)
            {
                users.Remove(currentUser);

                //Unsubscribing to events.
                eventUpdatePosts -= currentUser.UserNewPostAddedCallback.NewPostAdded;
            }
        }

        public List<Post> GetPosts()
        {
            return this.posts;
        }

        #endregion

        #region Viewer methods

        public List<Post> ViewPosts()
        {
            return this.posts;
        }

        public void ViewerSignIn(string username)
        {
            User currentViewer = new User(username);
            currentViewer.ViewerNewPostAddedCallback = OperationContext.Current.GetCallbackChannel<IViewerCallback>();
            this.viewers.Add(currentViewer);

            //Subscribing to events.
            eventViewerUpdatePosts += currentViewer.ViewerNewPostAddedCallback.UpdatePosts;
        }

        public void ViewerSignOut(string username)
        {
            User currentViewer = null;

            foreach (User viewer in viewers)
            {
                if (viewer.Username == username)
                {
                    currentViewer = viewer;
                }
            }

            if (currentViewer != null)
            {
                viewers.Remove(currentViewer);

                //Unsubscribing to events.
                eventViewerUpdatePosts -= currentViewer.ViewerNewPostAddedCallback.UpdatePosts;
            }
        }

        #endregion

        #region Profile methods

        public string GetPassword(string username)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.GetPassword(username);
        }

        public bool ChangePassword(string username, string password)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.ChangePassword(username, password);
        }

        #endregion

        #region Personal User methods

        public List<Post> GetUserPosts(string username)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.GetUserPosts(username);
        }

        public void DeleteUserPost(string username, int postId)
        {
            DBHelper dbHelper = new DBHelper();
            bool result = dbHelper.DeletePost(username, postId);

            if (result)
            {
                // Remove the post object from the list of posts.
                Post post = this.GetPostById(postId);
                if (post != null)
                {
                    this.posts.Remove(post);
                }
            }

            // Trigger event for all users.
            eventUpdatePosts(this.posts);
            // Trigger event for all viewers.
            eventViewerUpdatePosts(this.posts);
        }

        #endregion

        public bool SendMsg(Message msg)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.SendMessage(msg);
        }

        public List<PostMessage> GetPostMessage(string username)
        {
            List<PostMessage> postMessages = new List<PostMessage>();

            DBHelper dbHelper = new DBHelper();
            List<int> postIds = dbHelper.GetUserCommunicationPosts(username);

            if (postIds == null)
            {
                return null;
            }

            foreach (int id in postIds)
            {
                string title = dbHelper.GetPostTitle(id);
                string seller = dbHelper.GetPostSeller(id);
                PostMessage postMsg = new PostMessage(id, title, seller);
                postMessages.Add(postMsg);
            }

            return postMessages;
        }

        public List<Message> GetMessages(int postId)
        {
            DBHelper dbHelper = new DBHelper();
            return dbHelper.GetPostMessages(postId);
        }
    }
}
