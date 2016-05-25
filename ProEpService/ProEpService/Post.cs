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
        private string tittle;
        private Books bookinfo;
        private string place;

       

       public string Description
        {
            get { return this.description;}
            set { this.description = value;}


        }

        public string Tittle
        {
            get { return this.Tittle;}
            set { this.tittle = value;}


       }
        public Books BookInfo
        {
            get { return this.bookinfo;}
            set { this.bookinfo = value;}


        }

        public string Place
        {
            get { return this.place;}
            set { this.Place = value;}


        }
        
        
        public Post(string description, string tittle, Books bookinfo, string place)
        {

            this.description = description;
            this.tittle = tittle;
            this.bookinfo = bookinfo;
            this.place = place;

        }
    }
}
