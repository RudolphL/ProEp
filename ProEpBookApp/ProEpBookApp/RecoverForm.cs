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
    public partial class RecoverForm : Form
    {
        private ServiceReferenceApplication.LoginClient loginproxy;

        public RecoverForm()
        {
            this.loginproxy = new ServiceReferenceApplication.LoginClient();
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tbEmail.Text))
            {
                MessageBox.Show("Please enter your email");
                return;
            }

            bool result = this.loginproxy.RecoverPassword(this.tbEmail.Text);
            if (!result)
            {
                MessageBox.Show("You don't have an account with this email.\nPlease try again.");
                return;
            }

            MessageBox.Show("Email succesfully sent.\nCheck your email for your credentials.");
            this.Close();
        }
    }
}
