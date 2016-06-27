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
    public partial class ProfileForm : Form
    {
        private ServiceReferenceApplication.ProfileClient profileproxy;
        private string username;

        public ProfileForm(string username)
        {
            this.profileproxy = new ServiceReferenceApplication.ProfileClient();
            InitializeComponent();
            this.lbUsername.Text = username;
            this.username = username;
            this.lbPassword.Text = this.profileproxy.GetPassword(username);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNewPassword.Text) || String.IsNullOrWhiteSpace(tbRepeatPassword.Text))
            {
                MessageBox.Show("Please insert a password and repeat it.");
                return;
            }

            if (tbNewPassword.Text != tbRepeatPassword.Text)
            {
                MessageBox.Show("Passwords does not match.");
                return;
            }

            bool result = this.profileproxy.ChangePassword(this.username, tbNewPassword.Text);
            if (!result)
            {
                MessageBox.Show("Something went wrong, please try again later.");
                return;
            }

            lbPassword.Text = tbNewPassword.Text;
            MessageBox.Show("Password changed");
        }
    }
}
