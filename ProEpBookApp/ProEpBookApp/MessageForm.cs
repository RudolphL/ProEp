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
        private string username;
        public MessageForm(string user)
        {
            InitializeComponent();
            this.username = user;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
