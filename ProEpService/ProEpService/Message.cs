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
    public class Message
    {
        private int messageId;
        private String messageText;
        private String seller;
        private String client;
        private int postId;

         [DataMember]
        public int MessageId
        {
            get { return this.messageId; }
            private set { this.messageId = value; }
        }

         [DataMember]
        public String MessageText
        {
            get { return this.messageText; }
            private  set { this.messageText = value; }
        }

         [DataMember]
        public String Seller
        {
            get { return this.seller; }
            private set { this.seller = value; }
        }

         [DataMember]
        public String Client
        {
            get { return this.client; }
            private set { this.client = value; }
        }

         [DataMember]
        public int PostId
        {
            get { return this.postId; }
            private set { this.postId = value; }
        }

        public Message(int messageId, String messageText, String seller, String client, int postId)
        {
            this.messageId = messageId;
            this.messageText = messageText;
            this.seller = seller;
            this.client = client;
            this.postId = postId;
        }
    }
}
