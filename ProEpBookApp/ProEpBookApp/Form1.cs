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
    public partial class Form1 : Form
    {
        LoginForm lForm = null;
        Form1 mainForm = null;
        Register rForm = null;
        MessageForm mForm = null;

        public Form1()
        {
            InitializeComponent();
            mainForm = new Form1();
            lForm = new LoginForm();
            rForm = new Register();
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
    }
}
