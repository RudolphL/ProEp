using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace ProEpBookApp
{
    public partial class LoggedinForm : Form, ServiceReferenceApplication.IPortalCallback
    {
        private ServiceReferenceApplication.IPortal portalproxy;
        private string username;
        private List<ServiceReferenceApplication.Post> postList;

        public LoggedinForm(string user)
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            portalproxy = new ServiceReferenceApplication.PortalClient(context);
            portalproxy.SignIn(user);
            this.postList = portalproxy.GetPosts();
            this.UpdatePostList(postList);

            this.username = user;
            this.lbUsername.Text = user;
            this.Text = "Hello, " + user;
        }

        private void btnMyMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageform = new MessageForm(username);
            messageform.ShowDialog();
        }

        private void btnCreateAPost_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm(username, portalproxy);
            postForm.ShowDialog();
        }

        /// <summary>
        /// Exit application, user signs out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggedinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            portalproxy.SignOut(this.username);
            Application.Exit();
        }

        /// <summary>
        /// Update the Post list with the given List of posts.
        /// </summary>
        /// <param name="postList"></param>
        private void UpdatePostList(List<ServiceReferenceApplication.Post> postList)
        {
            this.listviewPosts.Items.Clear();

            foreach (ServiceReferenceApplication.Post item in postList)
            {
                string[] row = { item.Book.Author, item.Description, item.Book.Price.ToString(), item.Place };
                var listViewItem = new ListViewItem(row);
                listviewPosts.Items.Add(listViewItem);
            }
        }

        // Event triggered when a post is added
        public void NewPostAdded(List<ServiceReferenceApplication.Post> updatedList)
        {
            UpdatePostList(updatedList);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            this.postList = portalproxy.GetPosts();
            this.UpdatePostList(this.postList);
        }

        private void btnFilterAuthor_Click(object sender, EventArgs e)
        {
            // If empty textbox, get out of this method.
            if (String.IsNullOrWhiteSpace(txbFilterAuthor.Text))
                return;

            List<ServiceReferenceApplication.Post> tempList = new List<ServiceReferenceApplication.Post>();

            // Filtering the list
            foreach (var post in postList)
            {
                if (post.Book.Author.ToUpper().Contains(txbFilterAuthor.Text.ToUpper()))
                {
                    tempList.Add(post);
                }
            }

            // Displaying the list
            this.UpdatePostList(tempList);
        }

        private void btnFilterISBN_Click(object sender, EventArgs e)
        {
            // If empty textbox, get out of this method.
            if (String.IsNullOrWhiteSpace(txbFilterISBN.Text))
                return;

            List<ServiceReferenceApplication.Post> tempList = new List<ServiceReferenceApplication.Post>();

            // Filtering the list
            foreach (var post in postList)
            {
                if (post.Book.Isbn.ToUpper().Contains(txbFilterISBN.Text.ToUpper()))
                {
                    tempList.Add(post);
                }
            }

            // Displaying the list
            this.UpdatePostList(tempList);
        }

        private void btnFilterPrice_Click(object sender, EventArgs e)
        {
            // If empty textbox, get out of this method.
            if (String.IsNullOrWhiteSpace(tbPriceMin.Text) || String.IsNullOrWhiteSpace(tbPriceMax.Text))
                return;

            double minprice, maxprice;

            // Make sure the price is a number and above 0.
            try
            {
                minprice = Double.Parse(tbPriceMin.Text);
                maxprice = Double.Parse(tbPriceMax.Text);

                if (minprice < 0 || maxprice < 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a valid price range.");
                return;
            }

            List<ServiceReferenceApplication.Post> tempList = new List<ServiceReferenceApplication.Post>();

            // Filtering the list
            foreach (var post in postList)
            {
                double price = post.Book.Price;

                if (price >= minprice && price <= maxprice)
                {
                    tempList.Add(post);
                }
            }

            // Displaying the list
            this.UpdatePostList(tempList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txbSearch.Text.ToUpper();

            // If empty textbox, get out of this method.
            if (String.IsNullOrWhiteSpace(txt))
                return;

            List<ServiceReferenceApplication.Post> tempList = new List<ServiceReferenceApplication.Post>();

            // Filtering the list (Check all if contains the given text)
            foreach (var post in postList)
            {
                if (post.Description.ToUpper().Contains(txt) || post.Place.ToUpper().Contains(txt) || post.Title.ToUpper().Contains(txt) || post.Book.Author.ToUpper().Contains(txt) || post.Book.BookCondition.ToUpper().Contains(txt) || post.Book.Isbn.ToUpper().Contains(txt) || 
                    post.Book.Name.ToUpper().Contains(txt) || post.Book.Publisher.ToUpper().Contains(txt))
                {
                    tempList.Add(post);
                }
            }

            // Displaying the list
            this.UpdatePostList(tempList);
        }
    }
}
