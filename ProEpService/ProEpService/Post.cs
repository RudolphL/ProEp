using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEpService
{
    public class Post
    {
        private string description;
        private string title;
        private Books bookinfo;
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

       public Books BookInfo
       {
           get { return this.bookinfo; }
           set { this.bookinfo = value; }
       }

       public string Place
       {
           get { return this.place; }
           set { this.Place = value; }
       }


       public Post(string description, string title, Books bookinfo, string place)
       {

           this.description = description;
           this.title = title;
           this.bookinfo = bookinfo;
           this.place = place;

       }
    }
}
