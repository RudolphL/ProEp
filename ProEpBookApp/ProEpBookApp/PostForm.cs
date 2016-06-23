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
    public partial class PostForm : Form
    {
        // User
        private String username;

        // Post data
        private String title;
        private String place;
        private String description;

        // Book data
        private String name;
        private String isbn;
        private String author;
        private Double price;
        private String publisher;
        private String bookCondition;

        private ServiceReferenceApplication.IPortal portalproxy;

        public PostForm(String username, ServiceReferenceApplication.IPortal portalproxy)
        {
            this.portalproxy = portalproxy;
            this.username = username;
            InitializeComponent();
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbTitle.Text) || String.IsNullOrWhiteSpace(tbPlace.Text) || String.IsNullOrWhiteSpace(richDescription.Text))
            {
                MessageBox.Show("Please fill in the missing 'Post' information.");
                return;
            }

            if (String.IsNullOrWhiteSpace(tbBName.Text) || String.IsNullOrWhiteSpace(tbBIsbn.Text) || String.IsNullOrWhiteSpace(tbBAuthor.Text) || String.IsNullOrWhiteSpace(tbPrice.Text) || String.IsNullOrWhiteSpace(tbBPublisher.Text) || comboBCondition.SelectedItem == null)
            {
                MessageBox.Show("Please fill in the missing 'Book' information.");
                return;
            }

            // Make sure the price is a number and above 0.
            try
            {
                this.price = Double.Parse(tbPrice.Text);

                if (this.price <= 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a valid price.");
                return;
            }

            this.title = tbTitle.Text;
            this.place = tbPlace.Text;
            this.description = richDescription.Text;
            this.name = tbBName.Text;
            this.isbn = tbBIsbn.Text;
            this.author = tbBAuthor.Text;
            this.publisher = tbBPublisher.Text;
            this.bookCondition = comboBCondition.SelectedItem.ToString();

            this.portalproxy.AddPost(this.name, this.author, this.price, this.isbn, this.publisher, this.bookCondition, this.description, this.title, this.place, this.username);

            this.Close();
        }
    }
}
