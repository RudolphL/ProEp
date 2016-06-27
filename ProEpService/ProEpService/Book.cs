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
        private int bookId;

        [DataMember]
        public int BookId
        {
            get { return this.bookId; }
            set { this.bookId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [DataMember]
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        [DataMember]
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        [DataMember]
        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        [DataMember]
        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        [DataMember]
        public string BookCondition
        {
            get { return this.bookCondition; }
            set { this.bookCondition = value; }
        }

        public Book(string name, string author, double price, string isbn, string publisher, string bookCondition)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.isbn = isbn;
            this.publisher = publisher;
            this.bookCondition = bookCondition;
        }
    }
}

