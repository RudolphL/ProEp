using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEpBookApp
{
    public partial class SendMessageForm : Form
    {
        private ServiceReferenceApplication.CommunicationClient commproxy;
        private string seller;
        private string username;
        private int postId;

        public SendMessageForm(string seller, string username, int postId)
        {
            InitializeComponent();
            this.seller = seller;
            this.username = username;
            this.postId = postId;
            commproxy = new ServiceReferenceApplication.CommunicationClient();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(rtbText.Text))
            {
                MessageBox.Show("Your message is empty.");
                return;
            }

            var message = new ServiceReferenceApplication.Message();
            message.Sender = this.username;
            message.Receiver = this.seller;
            message.PostId = this.postId;
            message.MessageText = rtbText.Text;

            bool result = commproxy.SendMsg(message);

            if (!result)
            {
                MessageBox.Show("Someting went wrong, please try again later.");
                return;
            }

            MessageBox.Show("Message was successfully sent to the seller.");
            this.Close();
        }
    }
}
