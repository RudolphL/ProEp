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
    public class ServiceApplication : ILogin
    {
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
                    client.Port = 587; //465
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
    }
}
