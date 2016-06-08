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
    public partial class LoggedinForm : Form
    {
        private string username;
        public LoggedinForm(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void btnMyMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageform = new MessageForm(username);
            messageform.ShowDialog();
        }

        private void btnCreateAPost_Click(object sender, EventArgs e)
        {
        }
    }
}
