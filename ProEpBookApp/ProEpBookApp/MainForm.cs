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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.VisibleChanged += loginForm_VisibleChanged;
            loginForm.ShowDialog();
        }

        // This will hide this form if the user is logged in (if the Login Form is hidden)
        void loginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (((LoginForm)sender).GetLoggedIn())
            {
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

    }
}
