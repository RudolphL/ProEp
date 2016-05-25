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
    public class Post
    {
        private string description;
        private string title;
        private Book book;
        private string place;

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

       public string Title
       {
           get { return this.Title; }
           set { this.title = value; }
       }

       public Book Book
       {
           get { return this.book; }
           set { this.book = value; }
       }

       public string Place
       {
           get { return this.place; }
           set { this.Place = value; }
       }

       public Post(string description, string title, Book book, string place)
       {
           this.description = description;
           this.title = title;
           this.book = book;
           this.place = place;
       }
    }
}
