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
    public partial class LoginForm : Form
    {
        private ServiceReferenceApplication.LoginClient loginproxy;
        private bool loggedIn;

        public LoginForm()
        {
            this.loggedIn = false;
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            this.loginproxy = new ServiceReferenceApplication.LoginClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Please provide Username and Password.");
                    return;
                }
                
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (this.loginproxy.Login(username, password))
                {
                    LoggedinForm loggedInForm = new LoggedinForm(tbUsername.Text);
                    loggedInForm.Show();
                    this.loggedIn = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your username or password and try again.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            RecoverForm recoverForm = new RecoverForm();
            recoverForm.ShowDialog();
        }

        // This function is to help close the MainForm if the user is logged in.
        public bool GetLoggedIn()
        {
            return this.loggedIn;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
