namespace ProEpBookApp
{
    partial class MyPostsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.listviewPosts = new System.Windows.Forms.ListView();
            this.PostTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePost.Location = new System.Drawing.Point(130, 489);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(761, 47);
            this.btnDeletePost.TabIndex = 0;
            this.btnDeletePost.Text = "Delete Post";
            this.btnDeletePost.UseVisualStyleBackColor = true;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // listviewPosts
            // 
            this.listviewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PostTitle,
            this.Description});
            this.listviewPosts.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listviewPosts.FullRowSelect = true;
            this.listviewPosts.GridLines = true;
            this.listviewPosts.Location = new System.Drawing.Point(130, 33);
            this.listviewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listviewPosts.MultiSelect = false;
            this.listviewPosts.Name = "listviewPosts";
            this.listviewPosts.Size = new System.Drawing.Size(761, 424);
            this.listviewPosts.TabIndex = 1;
            this.listviewPosts.UseCompatibleStateImageBehavior = false;
            this.listviewPosts.View = System.Windows.Forms.View.Details;
            // 
            // PostTitle
            // 
            this.PostTitle.Text = "Post Title";
            this.PostTitle.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 750;
            // 
            // MyPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProEpBookApp.Properties.Resources.Paper_Proselyte_Graphics;
            this.ClientSize = new System.Drawing.Size(1016, 548);
            this.Controls.Add(this.listviewPosts);
            this.Controls.Add(this.btnDeletePost);
            this.Name = "MyPostsForm";
            this.Text = "My Posts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.ListView listviewPosts;
        private System.Windows.Forms.ColumnHeader PostTitle;
        private System.Windows.Forms.ColumnHeader Description;
    }
}