using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEpService
{
   public class Books
    {

        public string name;
        public string author;
        public float price;
        public string ISBN;
        public string publisher;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string IISBN
        {
            get { return this.ISBN; }
            set { this.ISBN = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public Books(string name, string author, float price, string ISBN, string publisher)
        {
            this.name = name;
            this.price = price;
            this.price = price;
            this.ISBN = ISBN;
            this.publisher = publisher;
        }


    }
}

