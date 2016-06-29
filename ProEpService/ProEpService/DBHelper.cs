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

                Int32 count = 0;

                while (reader.Read())
                {
                    if (reader[0] == DBNull.Value)
                    {
                        break;
                    }
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

                Int32 count = 0;

                while (reader.Read())
                {
                    if (reader[0] == DBNull.Value)
                    {
                        break;
                    }

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
       
        public bool CreatePost(Post post, string username, out int dbPostId, out int dbBookId)
        {
            // Set the postId
            int postId = this.GetPostMaxId() + 1;

            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                command.CommandText = "INSERT INTO post (post_id, title, description, place, client_username) VALUES ('"
                    + postId + "','" + post.Title + "','" + post.Description.Replace("'", "''") +"','" + post.Place + "','" + username + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();

                connection.Close();

                this.CreateBook(post.Book, postId, out dbBookId);
                dbPostId = postId;
                return true;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    dbPostId = -1;
                    dbBookId = -1;
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
     

        private bool CreateBook(Book book, int postId, out int dbBookId)
        {
            // Set the bookId
            int bookId = this.GetBookMaxId() + 1;

            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction mytransaction;

            // Start transaction
            mytransaction = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = mytransaction;

            try
            {
                command.CommandText = "INSERT INTO book (book_id, name, isbn, author, price, publisher, bookcondition, post_post_id) VALUES ('"
                    + bookId + "','" + book.Name + "','" + book.Isbn + "','" + book.Author + "'," + book.Price + ",'" + book.Publisher + "','" + book.BookCondition + "','" + postId + "');";
                command.ExecuteNonQuery();
                mytransaction.Commit();

                // Assign out parameter database book id
                dbBookId = bookId;
                return true;
            }
            catch
            {
                try
                {
                    mytransaction.Rollback();
                    dbBookId = -1;
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

        public List<Post> GetAllPosts()
        {
            List<Post> dbPosts = new List<Post>();

            try
            {
                String sql = ("SELECT * FROM post INNER JOIN book ON post.post_id = book.post_post_id;");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader["name"].ToString(), reader["author"].ToString(), Convert.ToDouble(reader["price"]), reader["isbn"].ToString(), reader["publisher"].ToString(), reader["bookCondition"].ToString());
                    book.BookId = Convert.ToInt32(reader["book_id"]);
                    Post post = new Post(reader["description"].ToString(), reader["title"].ToString(), book, reader["place"].ToString());
                    post.PostId = Convert.ToInt32(reader["post_id"]);
                    post.Seller = reader["client_username"].ToString();

                    dbPosts.Add(post);
                }

                return dbPosts;
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

        public string GetPassword(string username)
        {
            try
            {
                String sql = "SELECT password FROM client WHERE username = '" + username + "';";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string password = "";

                while (reader.Read())
                {
                    password = reader[0].ToString();
                }

                return password;
            }
            catch (Exception)
            {
                return "<Try again later>";
            }
            finally
            {
                connection.Close();
            }
        }

        public bool ChangePassword(string username, string password)
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
                command.CommandText = "UPDATE client SET password = '" + password + "' WHERE username = '" + username + "';";
                command.ExecuteNonQuery();
                mytransaction.Commit();

                return true;
            }
            catch (Exception)
            {
                mytransaction.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Post> GetUserPosts(string username)
        {
            List<Post> dbPosts = new List<Post>();

            try
            {
                String sql = ("SELECT * FROM post INNER JOIN book ON post.post_id = book.post_post_id WHERE client_username = '" + username + "';");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader["name"].ToString(), reader["author"].ToString(), Convert.ToDouble(reader["price"]), reader["isbn"].ToString(), reader["publisher"].ToString(), reader["bookCondition"].ToString());
                    book.BookId = Convert.ToInt32(reader["book_id"]);
                    Post post = new Post(reader["description"].ToString(), reader["title"].ToString(), book, reader["place"].ToString());
                    post.PostId = Convert.ToInt32(reader["post_id"]);
                    post.Seller = reader["client_username"].ToString();

                    dbPosts.Add(post);
                }

                return dbPosts;
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

        public bool DeletePost(string username, int postId)
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
                command.CommandText = "DELETE FROM book WHERE post_post_id = " + postId + ";";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM post WHERE post_id = " + postId + " AND client_username = '" + username + "';";
                command.ExecuteNonQuery();

                mytransaction.Commit();

                return true;
            }
            catch (Exception)
            {
                mytransaction.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool SendMessage(Message message)
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
                command.CommandText = "INSERT INTO message (messagetext, client_sender, client_receiver, msg_post_id) VALUES ('" + message.MessageText.Replace("'", "''") + "','" + message.Sender + "','" + message.Receiver + "'," + message.PostId + ");";
                command.ExecuteNonQuery();

                mytransaction.Commit();

                return true;
            }
            catch (Exception)
            {
                mytransaction.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        #region Message interaction

        public List<int> GetUserCommunicationPosts(string username)
        {
            List<int> postsids = new List<int>();

            try
            {
                String sql = ("SELECT DISTINCT msg_post_id FROM message WHERE client_sender = '" + username + "' OR client_receiver = '" + username + "';");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    postsids.Add(Convert.ToInt32(reader[0]));
                }

                return postsids;
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

        public List<Message> GetPostMessages(int postId)
        {
            List<Message> messages = new List<Message>();

            try
            {
                String sql = ("SELECT * FROM message WHERE msg_post_id = " + postId + " ORDER BY message_id DESC;");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Message msg = new Message(Convert.ToInt32(reader["message_id"]), reader["messagetext"].ToString(), reader["client_sender"].ToString(), reader["client_receiver"].ToString(), postId);
                    messages.Add(msg);
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

        public string GetPostTitle(int postId)
        {
            try
            {
                String sql = ("SELECT title from post WHERE post_id = " + postId + ";");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string title = "";

                while (reader.Read())
                {
                    title = reader[0].ToString();
                }

                return title;
            }
            catch (MySqlException)
            {
                return "";
            }
            catch (Exception)
            {
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        public string GetPostSeller(int postId)
        {
            try
            {
                String sql = ("SELECT client_username from post WHERE post_id = " + postId + ";");
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string title = "";

                while (reader.Read())
                {
                    title = reader[0].ToString();
                }

                return title;
            }
            catch (MySqlException)
            {
                return "";
            }
            catch (Exception)
            {
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion
    }
}
