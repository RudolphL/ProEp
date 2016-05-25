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
            bool exist = this.CheckLogin(username, password);
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

                if (true)
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
    }
}
