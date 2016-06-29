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
        private int postId;
        private string seller;

        [DataMember]
        public string Seller
        {
            get { return this.seller; }
            set { this.seller = value; }
        }

        [DataMember]
        public int PostId
        {
            get { return this.postId; }
            set { this.postId = value; }
        }

        [DataMember]
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        [DataMember]
       public string Title
       {
           get { return this.title; }
           set { this.title = value; }
       }

        [DataMember]
       public Book Book
       {
           get { return this.book; }
           set { this.book = value; }
       }

        [DataMember]
       public string Place
       {
           get { return this.place; }
           set { this.place = value; }
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
