using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEpService
{
    public class Message
    {

        //fields
        private int message_id;                //id possition of the message 
        private String messagetext;            //the message (text)
        private String client_sender;          //the name of the one who send the text
        private String client_receiver;        //the name of the one who receive the text

        #region properties
        public int Message_id
        {
            get { return this.message_id; }
            private set { this.message_id = value; }
        }

        public String MessageText
        {
            get { return this.messagetext; }
            private  set { this.messagetext = value; }
        }

        public String Client_sender
        {
            get { return this.client_sender; }
            private set { this.client_sender = value; }
        }

        public String Client_receiver
        {
            get { return this.client_receiver; }
            private set { this.client_receiver = value; }
        }
        #endregion
        //constructor

        public Message(int message_id, String messagetext, String client_sender, String client_receiver)
        {
            this.Message_id = message_id;
            this.MessageText = messagetext;
            this.Client_sender = client_sender;
            this.Client_receiver = client_receiver;

        }

        //method

        
    }
}
