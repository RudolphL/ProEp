using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEpService
{
   public class User
    {
        private string username;
        private string fullname;
        private long password;
        private string city;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Fullname
        {
            get { return this.fullname; }
            set { this.fullname = value; }
        }

        public long Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public User(string username, long password, string city)
        {
            this.username = username;
            this.password = password;
            this.city = city;
        }
    }
}



