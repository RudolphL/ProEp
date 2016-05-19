using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  xxx
{
    class Book
    {
        private string _bookname;
        private string _ISBN;
        private string _author;
        private double _price;
        private string publisher;

        //
        public string BookName
        {
            get { return this._bookname; }
            private set { this._bookname = value; }
        }
        public string ISBN
        {
            get { return this._ISBN; }
            private set { this._ISBN =  value; }
        }
        public string Author
        {
            get { return this._author; }
            private set { this._author = value; }
        }
        public double Price
        {
            get { return this._price; }
            private set { this._price = value; }
        }
        public string Publisher 
        {
            get { return this.publisher; }
            private set { this.publisher = value; }
        }

        public Book(string name, string isbn, string author, double price, string publisher)
        {
            this.BookName = name;
            this.ISBN = isbn;
            this.Author = author;
            this.Price = price;
            this.Publisher = publisher;
        }

    }
}
