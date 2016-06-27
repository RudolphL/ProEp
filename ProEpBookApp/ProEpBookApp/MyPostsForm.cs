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
    public partial class MyPostsForm : Form
    {
        private ServiceReferenceApplication.PersonalClient personalproxy;
        private List<ServiceReferenceApplication.Post> postList;
        private string username; 

        public MyPostsForm(string username)
        {
            this.username = username;
            this.personalproxy = new ServiceReferenceApplication.PersonalClient();
            this.postList = personalproxy.GetUserPosts(username);
            InitializeComponent();
            this.UpdatePostList(this.postList);
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            if (listviewPosts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a post");
                return;
            }

            ListViewItem item = listviewPosts.SelectedItems[0];
            string tagId = item.Tag.ToString();

            int postsCount = this.postList.Count;

            this.personalproxy.DeleteUserPost(this.username, Convert.ToInt32(tagId));

            // Update the list
            this.postList = personalproxy.GetUserPosts(username);
            this.UpdatePostList(this.postList);

            // If count does not change, then something went wrong (it was not deleted).
            if (this.postList.Count >= postsCount)
            {
                MessageBox.Show("Something went wrong, please try again later.");
                return;
            }
        }

        private void UpdatePostList(List<ServiceReferenceApplication.Post> postList)
        {
            this.listviewPosts.Items.Clear();

            foreach (ServiceReferenceApplication.Post item in postList)
            {
                string[] row = { item.Title, item.Description };
                ListViewItem listViewItem = new ListViewItem(row);
                // Adding the Tag as the id (now shown in the listview).
                listViewItem.Tag = item.PostId;
                listviewPosts.Items.Add(listViewItem);
            }
        }
    }
}
