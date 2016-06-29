namespace ProEpBookApp
{
    partial class LoggedinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedinForm));
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnMyPost = new System.Windows.Forms.Button();
            this.btnMyMessage = new System.Windows.Forms.Button();
            this.btnCreateAPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.listviewPosts = new System.Windows.Forms.ListView();
            this.PostTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPriceMax = new System.Windows.Forms.TextBox();
            this.tbPriceMin = new System.Windows.Forms.TextBox();
            this.txbFilterISBN = new System.Windows.Forms.TextBox();
            this.txbFilterAuthor = new System.Windows.Forms.TextBox();
            this.btnFilterPrice = new System.Windows.Forms.Button();
            this.btnFilterISBN = new System.Windows.Forms.Button();
            this.btnFilterAuthor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(19, 25);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(179, 54);
            this.btnMyProfile.TabIndex = 1;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnMyPost
            // 
            this.btnMyPost.Location = new System.Drawing.Point(206, 25);
            this.btnMyPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyPost.Name = "btnMyPost";
            this.btnMyPost.Size = new System.Drawing.Size(179, 54);
            this.btnMyPost.TabIndex = 2;
            this.btnMyPost.Text = "My Posts";
            this.btnMyPost.UseVisualStyleBackColor = true;
            this.btnMyPost.Click += new System.EventHandler(this.btnMyPost_Click);
            // 
            // btnMyMessage
            // 
            this.btnMyMessage.Location = new System.Drawing.Point(392, 25);
            this.btnMyMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyMessage.Name = "btnMyMessage";
            this.btnMyMessage.Size = new System.Drawing.Size(179, 54);
            this.btnMyMessage.TabIndex = 3;
            this.btnMyMessage.Text = "My Message";
            this.btnMyMessage.UseVisualStyleBackColor = true;
            this.btnMyMessage.Click += new System.EventHandler(this.btnMyMessage_Click);
            // 
            // btnCreateAPost
            // 
            this.btnCreateAPost.Location = new System.Drawing.Point(28, 46);
            this.btnCreateAPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAPost.Name = "btnCreateAPost";
            this.btnCreateAPost.Size = new System.Drawing.Size(280, 86);
            this.btnCreateAPost.TabIndex = 5;
            this.btnCreateAPost.Text = "Create A Post";
            this.btnCreateAPost.UseVisualStyleBackColor = true;
            this.btnCreateAPost.Click += new System.EventHandler(this.btnCreateAPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.btnAbout);
            this.groupBox1.Controls.Add(this.btnMyMessage);
            this.groupBox1.Controls.Add(this.btnMyPost);
            this.groupBox1.Controls.Add(this.btnMyProfile);
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(976, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(780, 25);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 54);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCreateAPost);
            this.groupBox2.Location = new System.Drawing.Point(1050, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(336, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Beige;
            this.groupBox4.Controls.Add(this.btnClearFilter);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txbSearch);
            this.groupBox4.Controls.Add(this.listviewPosts);
            this.groupBox4.Location = new System.Drawing.Point(24, 137);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(972, 546);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Posts";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(817, 46);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(117, 37);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(45, 47);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(387, 34);
            this.txbSearch.TabIndex = 1;
            // 
            // listviewPosts
            // 
            this.listviewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PostTitle,
            this.Description,
            this.Location,
            this.Price,
            this.Condition});
            this.listviewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listviewPosts.FullRowSelect = true;
            this.listviewPosts.GridLines = true;
            this.listviewPosts.Location = new System.Drawing.Point(45, 100);
            this.listviewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listviewPosts.MultiSelect = false;
            this.listviewPosts.Name = "listviewPosts";
            this.listviewPosts.Size = new System.Drawing.Size(889, 400);
            this.listviewPosts.TabIndex = 0;
            this.listviewPosts.UseCompatibleStateImageBehavior = false;
            this.listviewPosts.View = System.Windows.Forms.View.Details;
            this.listviewPosts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewPosts_MouseDoubleClick);
            // 
            // PostTitle
            // 
            this.PostTitle.Text = "Title";
            this.PostTitle.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 400;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 89;
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            this.Condition.Width = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbPriceMax);
            this.groupBox5.Controls.Add(this.tbPriceMin);
            this.groupBox5.Controls.Add(this.txbFilterISBN);
            this.groupBox5.Controls.Add(this.txbFilterAuthor);
            this.groupBox5.Controls.Add(this.btnFilterPrice);
            this.groupBox5.Controls.Add(this.btnFilterISBN);
            this.groupBox5.Controls.Add(this.btnFilterAuthor);
            this.groupBox5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1050, 314);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(336, 369);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "max range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "min range";
            // 
            // tbPriceMax
            // 
            this.tbPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceMax.Location = new System.Drawing.Point(179, 275);
            this.tbPriceMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbPriceMax.Name = "tbPriceMax";
            this.tbPriceMax.Size = new System.Drawing.Size(140, 34);
            this.tbPriceMax.TabIndex = 6;
            // 
            // tbPriceMin
            // 
            this.tbPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceMin.Location = new System.Drawing.Point(19, 275);
            this.tbPriceMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbPriceMin.Name = "tbPriceMin";
            this.tbPriceMin.Size = new System.Drawing.Size(140, 34);
            this.tbPriceMin.TabIndex = 6;
            // 
            // txbFilterISBN
            // 
            this.txbFilterISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterISBN.Location = new System.Drawing.Point(19, 137);
            this.txbFilterISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txbFilterISBN.Name = "txbFilterISBN";
            this.txbFilterISBN.Size = new System.Drawing.Size(299, 34);
            this.txbFilterISBN.TabIndex = 5;
            // 
            // txbFilterAuthor
            // 
            this.txbFilterAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterAuthor.Location = new System.Drawing.Point(19, 23);
            this.txbFilterAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txbFilterAuthor.Name = "txbFilterAuthor";
            this.txbFilterAuthor.Size = new System.Drawing.Size(299, 34);
            this.txbFilterAuthor.TabIndex = 3;
            // 
            // btnFilterPrice
            // 
            this.btnFilterPrice.Location = new System.Drawing.Point(19, 314);
            this.btnFilterPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterPrice.Name = "btnFilterPrice";
            this.btnFilterPrice.Size = new System.Drawing.Size(300, 47);
            this.btnFilterPrice.TabIndex = 4;
            this.btnFilterPrice.Text = "Price Search";
            this.btnFilterPrice.UseVisualStyleBackColor = true;
            this.btnFilterPrice.Click += new System.EventHandler(this.btnFilterPrice_Click);
            // 
            // btnFilterISBN
            // 
            this.btnFilterISBN.Location = new System.Drawing.Point(19, 175);
            this.btnFilterISBN.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterISBN.Name = "btnFilterISBN";
            this.btnFilterISBN.Size = new System.Drawing.Size(300, 47);
            this.btnFilterISBN.TabIndex = 2;
            this.btnFilterISBN.Text = "ISBN Search";
            this.btnFilterISBN.UseVisualStyleBackColor = true;
            this.btnFilterISBN.Click += new System.EventHandler(this.btnFilterISBN_Click);
            // 
            // btnFilterAuthor
            // 
            this.btnFilterAuthor.Location = new System.Drawing.Point(19, 61);
            this.btnFilterAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterAuthor.Name = "btnFilterAuthor";
            this.btnFilterAuthor.Size = new System.Drawing.Size(300, 42);
            this.btnFilterAuthor.TabIndex = 0;
            this.btnFilterAuthor.Text = "Author Search";
            this.btnFilterAuthor.UseVisualStyleBackColor = true;
            this.btnFilterAuthor.Click += new System.EventHandler(this.btnFilterAuthor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(24, 32);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(105, 24);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "User Name";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(231, 16);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(97, 50);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnSignOut);
            this.groupBox3.Controls.Add(this.lbUsername);
            this.groupBox3.Location = new System.Drawing.Point(1050, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(336, 85);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User";
            // 
            // LoggedinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProEpBookApp.Properties.Resources.Paper_Proselyte_Graphics;
            this.ClientSize = new System.Drawing.Size(1477, 702);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoggedinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggedinForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnMyPost;
        private System.Windows.Forms.Button btnMyMessage;
        private System.Windows.Forms.Button btnCreateAPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listviewPosts;
        private System.Windows.Forms.ColumnHeader PostTitle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilterPrice;
        private System.Windows.Forms.Button btnFilterISBN;
        private System.Windows.Forms.Button btnFilterAuthor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.TextBox tbPriceMin;
        private System.Windows.Forms.TextBox txbFilterISBN;
        private System.Windows.Forms.TextBox txbFilterAuthor;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPriceMax;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.Button btnAbout;
    }
}

