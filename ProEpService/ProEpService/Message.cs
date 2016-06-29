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
        private String sender;
        private String receiver;
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
        public String Sender
        {
            get { return this.sender; }
            private set { this.sender = value; }
        }

         [DataMember]
        public String Receiver
        {
            get { return this.receiver; }
            private set { this.receiver = value; }
        }

         [DataMember]
        public int PostId
        {
            get { return this.postId; }
            private set { this.postId = value; }
        }

        public Message(int messageId, String messageText, String sender, String receiver, int postId)
        {
            this.messageId = messageId;
            this.messageText = messageText;
            this.sender = sender;
            this.receiver = receiver;
            this.postId = postId;
        }
    }
}
