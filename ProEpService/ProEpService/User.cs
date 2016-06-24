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
    public class User
    {
        private string username;

        public User(string playername)
        {
            this.username = playername;
        }

        [DataMember]
        public string Username { get { return this.username; } set { this.username = value; } }

        public IPortalCallback UserNewPostAddedCallback { get; set; }

        public IViewerCallback ViewerNewPostAddedCallback { get; set; }
    }
}



