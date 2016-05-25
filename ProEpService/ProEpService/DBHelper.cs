using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProEpService
{
    public class DBHelper
    {
        private MySqlConnection connection;

        public DBHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi288112;" +
                                    "user id=dbi288112;" +
                                    "password=rC6qF45clL;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }

        /// <summary>
        /// Checks the COUNT(*) in the database, if it's 1, then the user can log in.
        /// </summary>
        /// <param name="playername"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckLogin(string username, string password)
        {
            try
            {
                bool returnValue = false;

                String sql = "SELECT COUNT(*) FROM client WHERE username = '" + username + "' AND password = '" + password + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                // If user is found, make the returnValue true.
                if (count == 1)
                {
                    returnValue = true;
                }
                return returnValue;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Check if there already exist a user with this username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckExist(string username)
        {
            try
            {
                bool returnValue = false;

                String sql = "SELECT COUNT(*) FROM client WHERE username = '" + username + "';";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                // If user is found, make the returnValue true.
                if (count == 1)
                {
                    returnValue = true;
                }
                return returnValue;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Create a user with the parameters.
        /// Checks first if there is already a user with the username or email that exist.
        /// Function algorithm:
        /// Return -1 : Exception
        /// Return 0 : User exist
        /// Return 1 : Email exist
        /// Return 2 : User created
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="city"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int CreateUser(string username, string password, string name, string city, string email)
        {
            bool exist = this.CheckExist(username);
            bool emailExist = this.CheckEmail(email);

            // User already exist
            if (exist)
            {
                return 0;
            }
            // Email already exist
            if (emailExist)
            {
                return 1;
            }

            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                command.CommandText = "INSERT INTO client (username, name, password, email) VALUES ('" + username + "','" + name + "','" + password + "','" + email + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();
                return 2;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    return -1;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Returns true if the email currently exist in the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckEmail(string email)
        {
            bool returnValue = false;

            try
            {
                String sql = ("SELECT COUNT(*) FROM client WHERE email = '" + email + "';");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                if (count == 1)
                {
                    returnValue = true;
                }
                return returnValue;
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public string[] GetPrivateCredentials(string email)
        {
            //Arrayposition: 0 username, 1 name, 2 password
            String[] stringsarray = new String[3];
            
            try
            {
                bool checkEmail = this.CheckEmail(email);

                if (checkEmail)
                {
                    String sql = "SELECT username, name, password FROM client WHERE email = '" + email + "';";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        stringsarray[0] = reader[0].ToString();
                        stringsarray[1] = reader[1].ToString();
                        stringsarray[2] = reader[2].ToString();
                    }
                    return stringsarray;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get the max id in the post table.
        /// </summary>
        /// <returns></returns>
        public int GetPostMaxId()
        {
            try
            {
                String sql = ("SELECT MAX(post_id) from post;");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                return count;
            }
            catch (MySqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get the max id in the book table.
        /// </summary>
        /// <returns></returns>
        public int GetBookMaxId()
        {
            try
            {
                String sql = ("SELECT MAX(book_id) from book;");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                return count;
            }
            catch (MySqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
       
        public bool CreatePost(Post post, string username)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                // Set the postId
                int postId = this.GetPostMaxId() + 1;
                command.CommandText = "INSERT INTO post (post_id, title, description, place, client_username) VALUES ('"
                    + postId + "','" + post.Title + "','" + post.Description + "','" + post.Place + "','" + username + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();

                connection.Close();
                this.CreateBook(post.Book, postId);

                return true;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }
     

        public bool CreateBook(Book book, int postId)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                // Set the bookId
                int bookId = this.GetBookMaxId() + 1;
                command.CommandText = "INSERT INTO book (book_id, name, isbn, author, price, publisher, image, bookcondition, post_post_id) VALUES ('"
                    + bookId + "','" + book.Name + "','" + book.Isbn + "','" + book.Author + "'," + book.Price + ",'" + book.Publisher + "'," + null + ",'" + book.BookCondition + "','" + postId + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();

                return true;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        #region Message interaction

        /// <summary>
        /// Get the max id in the message table
        /// </summary>
        /// <returns></returns>
        private int GetMessageMaxId()
        {
            try
            {
                String sql = ("SELECT MAX(message_id) from message;");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }

                return count;
            }
            catch (MySqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// insert a row in to the message table
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool InsertMessage(Message message)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                int messageId = this.GetMessageMaxId() + 1;
                command.CommandText = "INSERT INTO message (message_id, messagetext, client_sender, client_receiver) VALUES ('" + messageId + "','" + message.MessageText + "','" + message.Client_sender + "','" + message.Client_receiver + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();
                return true;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get the list of person who have conversation with the selected user
        /// </summary>
        /// <param name="username">selected user's username</param>
        /// <returns></returns>
        public List<String> GetListOfPersonOnMessage(String username)
        {
            try
            {
                List<String> persons = new List<String>();

                String personsqlreceiver = "SELECT DISTINCT client_receiver FROM message WHERE client_sender = '" + username + "';";
                MySqlCommand command = new MySqlCommand(personsqlreceiver, connection);

                String person = "";

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    person = Convert.ToString(reader[0]);
                    persons.Add(person);
                }

                String personsqlsender = "SELECT DISTINCT client sender FROM message WHERE client_receiver NOT IN ( SELECT DISTINCT client_receiver FROM message WHERE client_sender = '" + username + "');";
                MySqlCommand command2 = new MySqlCommand(personsqlreceiver, connection);
                person = "";

                while (reader.Read())
                {
                    person = Convert.ToString(reader[0]);
                    persons.Add(person);
                }
                return persons;

            }
            catch (MySqlException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get a list of all Message from a selected send and a selected receiver
        /// </summary>
        /// <param name="sender_username"></param>
        /// <param name="receiver_username"></param>
        /// <returns></returns>
        public List<Message> GetMessages(String sender_username, String receiver_username)
        {
            try
            {
                List<Message> messages = new List<Message>();

                String messagesql = "SELECT * FROM message WHERE client_sender = '" + sender_username + "' AND client_receiver = '" + receiver_username + "';";

                MySqlCommand command = new MySqlCommand(messagesql, connection);

                int messageid = 0;
                String text = "";
                String sender = "";
                String receiver = "";

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    messageid = Convert.ToInt32(reader[0]);
                    text = Convert.ToString(reader[1]);
                    sender = Convert.ToString(reader[2]);
                    receiver = Convert.ToString(reader[3]);

                    Message tempmessage = new Message(messageid, text, sender, receiver);
                    messages.Add(tempmessage);
                }
                return messages;

            }
            catch (MySqlException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion
    }
}
