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
    public partial class MessageForm : Form 
    {
        private ServiceReferenceApplication.CommunicationClient proxycomm;
        private string username, receiver;
        private bool running;
        private List<ServiceReferenceApplication.PostMessage> postMessages;

        public MessageForm(string username)
        {
            this.running = false;
            this.proxycomm = new ServiceReferenceApplication.CommunicationClient();
            InitializeComponent();
            this.username = username;
            this.postMessages = proxycomm.GetPostMessage(username);
            this.lbPosts.DataSource = this.postMessages;
            this.lbPosts.DisplayMember = "Title";
            this.lbPosts.ValueMember = "Title";
            this.running = true;
            ShowMessages();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tbChatbox.Text))
            {
                MessageBox.Show("Nothing to send");
                return;
            }

            var postMsg = lbPosts.SelectedItem as ServiceReferenceApplication.PostMessage;
            var message = new ServiceReferenceApplication.Message();
            message.Sender = this.username;
            message.Receiver = this.receiver;
            message.PostId = postMsg.PostId;
            message.MessageText = tbChatbox.Text;

            proxycomm.SendMsg(message);
            ShowMessages();
            this.tbChatbox.Text = "";
        }

        private void lbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (running && lbPosts.SelectedIndex >= 0)
            {
                ShowMessages();
            }
        }

        private void ShowMessages()
        {
            if (lbPosts.Items.Count <= 0)
            {
                tbChatbox.Enabled = false;
                btnSend.Enabled = false;
                return;
            }
            tbChatbox.Enabled = true;
            btnSend.Enabled = true;


            var postMsg = lbPosts.SelectedItem as ServiceReferenceApplication.PostMessage;
            var messages = proxycomm.GetMessages(postMsg.PostId);

            // Get the name of the receiver.
            if (messages != null)
            {
                if (this.username == messages[0].Receiver)
                {
                    this.receiver = messages[0].Sender;
                }
                else
                {
                    this.receiver = messages[0].Receiver;
                }
            }

            rtbChatLog.Clear();

            messages.Reverse();

            foreach (var msg in messages)
            {
                if (username == postMsg.Seller && username == msg.Sender)
                {
                    rtbChatLog.AppendText("Me: " + msg.MessageText);
                    rtbChatLog.AppendText(Environment.NewLine);
                }

                else if (username == postMsg.Seller && username == msg.Receiver)
                {
                    rtbChatLog.AppendText(msg.Sender + ": " + msg.MessageText);
                    rtbChatLog.AppendText(Environment.NewLine);
                }

                else if (username != postMsg.Seller && username == msg.Sender)
                {
                    rtbChatLog.AppendText("Me: " + msg.MessageText);
                    rtbChatLog.AppendText(Environment.NewLine);
                }

                else if (username != postMsg.Seller && username == msg.Receiver)
                {
                    rtbChatLog.AppendText(msg.Sender + ": " + msg.MessageText);
                    rtbChatLog.AppendText(Environment.NewLine);
                }

                rtbChatLog.ScrollToCaret();
            }
        }

        private void lbPosts_MouseHover(object sender, EventArgs e)
        {
            ShowMessages();
        }

        private void MessageForm_Activated(object sender, EventArgs e)
        {
            ShowMessages();
        }
    }
}
