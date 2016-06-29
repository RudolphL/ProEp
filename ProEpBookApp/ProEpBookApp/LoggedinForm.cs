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
        }

        private void btnMyMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageform = new MessageForm(username);
            messageform.FormClosed += messageform_FormClosed;
            this.Visible = false;
            messageform.Show();
        }

        void messageform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
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
                string[] row = { item.Title, item.Description, item.Place, item.Book.Price.ToString(), item.Book.BookCondition };
                var listViewItem = new ListViewItem(row);
                // Adding the Tag as the id (now shown in the listview).
                listViewItem.Tag = item.PostId;
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

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this.username);
            profileForm.FormClosed += profileForm_FormClosed;
            profileForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Gets called if the ProfileForm closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void profileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void btnMyPost_Click(object sender, EventArgs e)
        {
            MyPostsForm myPostsForm = new MyPostsForm(this.username);
            myPostsForm.FormClosed += myPostsForm_FormClosed;
            myPostsForm.Show();
            this.Visible = false;
        }

        void myPostsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private ServiceReferenceApplication.Post GetPost(int id)
        {
            foreach (var item in this.postList)
            {
                if (item.PostId == id)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Double click event for the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listviewPosts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listviewPosts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a post");
                return;
            }

            ListViewItem item = listviewPosts.SelectedItems[0];
            string tagId = item.Tag.ToString();

            var post = this.GetPost(Convert.ToInt32(tagId));
            ViewPostForm viewPostForm = new ViewPostForm(this.username, post);
            viewPostForm.FormClosed += viewPostForm_FormClosed;
            viewPostForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Triggered when the ViewPostForm is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void viewPostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
    }
}
