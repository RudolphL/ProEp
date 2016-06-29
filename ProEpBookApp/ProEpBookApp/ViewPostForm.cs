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
    public partial class ViewPostForm : Form
    {
        private string username;
        private ServiceReferenceApplication.Post post;

        public ViewPostForm(string username, ServiceReferenceApplication.Post post)
        {
            InitializeComponent();
            this.username = username;
            this.post = post;

            this.Text = post.Title;
            // <><><><> Post
            this.lbTitle.Text = post.Title;
            this.rtbDescription.Text = post.Description;
            this.lbLocation.Text = post.Place;
            // <><><><> Book
            this.lbName.Text = post.Book.Name;
            this.lbIsbn.Text = post.Book.Isbn;
            this.lbAuthor.Text = post.Book.Author;
            this.lbPublisher.Text = post.Book.Publisher;
            this.lbCondition.Text = post.Book.BookCondition;
            this.lbPrice.Text = "€ " + post.Book.Price.ToString();
        }

        private void btnMessageSeller_Click(object sender, EventArgs e)
        {
            if (this.username.Equals(post.Seller))
            {
                MessageBox.Show("This is your post, you cannot send a message to yourself.");
                return;
            }

            SendMessageForm form = new SendMessageForm(post.Seller, this.username, post.PostId);
            form.ShowDialog();
        }
    }
}
