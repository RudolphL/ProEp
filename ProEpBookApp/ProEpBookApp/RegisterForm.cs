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
    public partial class RegisterForm : Form
    {
        private ServiceReferenceApplication.LoginClient loginproxy;

        public RegisterForm()
        {
            this.loginproxy = new ServiceReferenceApplication.LoginClient();
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbPasswordConfirm.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name, city, username, email, password, confirmPassword;

            if (tbCity.Text == "" || tbName.Text == "" || tbPassword.Text == "" || tbPasswordConfirm.Text == "" || tbEmail.Text == "" || tbUsername.Text == "")
            {
                MessageBox.Show("Please provide all information.");
                return;
            }

            name = tbName.Text;
            city = tbCity.Text;
            username = tbUsername.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            confirmPassword = tbPasswordConfirm.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
            }

            //if (password.ToCharArray().Length < 8 || password.ToCharArray().Length > 16)
            //{
            //    MessageBox.Show("Your password has to be \nbetween 8 and 16 characters");
            //    return;
            //}

            int result = loginproxy.Register(username, password, name, city, email);

            switch (result)
            {
                case 0:
                    MessageBox.Show("Username already exists");
                    break;
                case 1:
                    MessageBox.Show("Email address already exists");
                    break;
                case 2:
                    MessageBox.Show("Account created. \nYou can now log in.");
                    this.Close();
                    break;
                case -1:
                    MessageBox.Show("Database errors occurd. Please try again later.");
                    break;
            }
        }
    }
}
