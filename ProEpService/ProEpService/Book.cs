using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ProEpService
{
    [DataContract]
   public class Book
    {
        private string name;
        private string isbn;
        private string author;
        private double price;
        private string publisher;
        private string bookCondition;

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

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public string BookCondition
        {
            get { return this.bookCondition; }
            set { this.bookCondition = value; }
        }

        public Book(string name, string author, double price, string isbn, string publisher, string bookCondition)
        {
            this.name = name;
            this.price = price;
            this.price = price;
            this.isbn = isbn;
            this.publisher = publisher;
            this.bookCondition = bookCondition;
        }
    }
}

