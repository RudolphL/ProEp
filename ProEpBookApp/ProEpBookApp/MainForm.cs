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
        MainForm mainForm = null;
        LoginForm lForm = null;
        RegisterForm rForm = null;
        

        public MainForm()
        {
      //      InitializeComponent();
            mainForm = new MainForm();
            lForm = new LoginForm();
            rForm = new RegisterForm();
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

    }
}
