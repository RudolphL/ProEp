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
        LoginForm lForm = null;
        LoggedinForm mainForm = null;
        RegisterForm rForm = null;
        MessageForm mForm = null;

        public LoggedinForm()
        {
            InitializeComponent();
            mainForm = new LoggedinForm();
            lForm = new LoginForm();
            rForm = new RegisterForm();
            mForm = new MessageForm();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lForm.Show();
            mainForm.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            rForm.Show();
            mainForm.Hide();
        }

        private void btnMyMessage_Click(object sender, EventArgs e)
        {
            mForm.Show();
            mainForm.Hide();
        }

        private void btnCreateAPost_Click(object sender, EventArgs e)
        {

        }
    }
}
