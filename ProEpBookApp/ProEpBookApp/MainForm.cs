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
    public partial class MainForm : Form, ServiceReferenceApplication.IViewerCallback
    {
        private String uniqueId;
        private ServiceReferenceApplication.IViewer viewerproxy;
        private List<ServiceReferenceApplication.Post> postList;

        public MainForm()
        {
            InitializeComponent();
            this.uniqueId = Guid.NewGuid().ToString("N");
            InstanceContext context = new InstanceContext(this);
            viewerproxy = new ServiceReferenceApplication.ViewerClient(context);
            viewerproxy.ViewerSignIn(uniqueId);
            this.postList = viewerproxy.ViewPosts();
            this.UpdatePostList(postList);
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
                this.viewerproxy.ViewerSignOut(this.uniqueId);
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
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

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            this.postList = viewerproxy.ViewPosts();
            this.UpdatePostList(this.postList);
        }

        public void UpdatePosts(List<ServiceReferenceApplication.Post> updatedList)
        {
            UpdatePostList(updatedList);
        }


        /// <summary>
        /// Event triggered: Update the Post list with the given List of posts.
        /// </summary>
        /// <param name="postList"></param>
        private void UpdatePostList(List<ServiceReferenceApplication.Post> postList)
        {
            this.listviewPosts.Items.Clear();
            this.postList = postList;

            foreach (ServiceReferenceApplication.Post item in this.postList)
            {
                string[] row = { item.Title, item.Description, item.Place, item.Book.Price.ToString(), item.Book.BookCondition };
                var listViewItem = new ListViewItem(row);
                // Adding the Tag as the id (now shown in the listview).
                listViewItem.Tag = item.PostId;
                listviewPosts.Items.Add(listViewItem);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                this.viewerproxy.ViewerSignOut(this.uniqueId);
            }
        }
    }
}
