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
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnMyPost = new System.Windows.Forms.Button();
            this.btnMyMessage = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCreateAPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbFilterPrice = new System.Windows.Forms.TextBox();
            this.txbFilterISBN = new System.Windows.Forms.TextBox();
            this.txbFilterAuthor = new System.Windows.Forms.TextBox();
            this.btnFilterPrice = new System.Windows.Forms.Button();
            this.btnFilterISBN = new System.Windows.Forms.Button();
            this.btnFilterAuthor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(13, 23);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(179, 54);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "Home Page";
            this.btnHomePage.UseVisualStyleBackColor = true;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(200, 25);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(179, 54);
            this.btnMyProfile.TabIndex = 1;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // btnMyPost
            // 
            this.btnMyPost.Location = new System.Drawing.Point(387, 25);
            this.btnMyPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMyPost.Name = "btnMyPost";
            this.btnMyPost.Size = new System.Drawing.Size(179, 54);
            this.btnMyPost.TabIndex = 2;
            this.btnMyPost.Text = "My Books";
            this.btnMyPost.UseVisualStyleBackColor = true;
            // 
            // btnMyMessage
            // 
            this.btnMyMessage.Location = new System.Drawing.Point(573, 25);
            this.btnMyMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMyMessage.Name = "btnMyMessage";
            this.btnMyMessage.Size = new System.Drawing.Size(179, 54);
            this.btnMyMessage.TabIndex = 3;
            this.btnMyMessage.Text = "My Message";
            this.btnMyMessage.UseVisualStyleBackColor = true;
            this.btnMyMessage.Click += new System.EventHandler(this.btnMyMessage_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(760, 25);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 54);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnCreateAPost
            // 
            this.btnCreateAPost.Location = new System.Drawing.Point(45, 37);
            this.btnCreateAPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAPost.Name = "btnCreateAPost";
            this.btnCreateAPost.Size = new System.Drawing.Size(300, 86);
            this.btnCreateAPost.TabIndex = 5;
            this.btnCreateAPost.Text = "Create A Post";
            this.btnCreateAPost.UseVisualStyleBackColor = true;
            this.btnCreateAPost.Click += new System.EventHandler(this.btnCreateAPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbout);
            this.groupBox1.Controls.Add(this.btnMyMessage);
            this.groupBox1.Controls.Add(this.btnMyPost);
            this.groupBox1.Controls.Add(this.btnMyProfile);
            this.groupBox1.Controls.Add(this.btnHomePage);
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(976, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateAPost);
            this.groupBox2.Location = new System.Drawing.Point(1063, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(371, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegister);
            this.groupBox3.Controls.Add(this.btnLogin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1020, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(431, 79);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(316, 15);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 50);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(211, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txbSearch);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Location = new System.Drawing.Point(24, 137);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(972, 546);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Posts";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(45, 47);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(387, 34);
            this.txbSearch.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Author,
            this.Description,
            this.Price,
            this.Place});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(45, 100);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(889, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 135;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 352;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 89;
            // 
            // Place
            // 
            this.Place.Text = "Place";
            this.Place.Width = 390;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbFilterPrice);
            this.groupBox5.Controls.Add(this.txbFilterISBN);
            this.groupBox5.Controls.Add(this.txbFilterAuthor);
            this.groupBox5.Controls.Add(this.btnFilterPrice);
            this.groupBox5.Controls.Add(this.btnFilterISBN);
            this.groupBox5.Controls.Add(this.btnFilterAuthor);
            this.groupBox5.Location = new System.Drawing.Point(1068, 314);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(364, 324);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // txbFilterPrice
            // 
            this.txbFilterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterPrice.Location = new System.Drawing.Point(40, 213);
            this.txbFilterPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFilterPrice.Name = "txbFilterPrice";
            this.txbFilterPrice.Size = new System.Drawing.Size(299, 34);
            this.txbFilterPrice.TabIndex = 6;
            // 
            // txbFilterISBN
            // 
            this.txbFilterISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterISBN.Location = new System.Drawing.Point(40, 116);
            this.txbFilterISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFilterISBN.Name = "txbFilterISBN";
            this.txbFilterISBN.Size = new System.Drawing.Size(299, 34);
            this.txbFilterISBN.TabIndex = 5;
            // 
            // txbFilterAuthor
            // 
            this.txbFilterAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterAuthor.Location = new System.Drawing.Point(40, 23);
            this.txbFilterAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFilterAuthor.Name = "txbFilterAuthor";
            this.txbFilterAuthor.Size = new System.Drawing.Size(299, 34);
            this.txbFilterAuthor.TabIndex = 3;
            // 
            // btnFilterPrice
            // 
            this.btnFilterPrice.Location = new System.Drawing.Point(40, 252);
            this.btnFilterPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterPrice.Name = "btnFilterPrice";
            this.btnFilterPrice.Size = new System.Drawing.Size(300, 47);
            this.btnFilterPrice.TabIndex = 4;
            this.btnFilterPrice.Text = "Price Search";
            this.btnFilterPrice.UseVisualStyleBackColor = true;
            // 
            // btnFilterISBN
            // 
            this.btnFilterISBN.Location = new System.Drawing.Point(40, 159);
            this.btnFilterISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterISBN.Name = "btnFilterISBN";
            this.btnFilterISBN.Size = new System.Drawing.Size(300, 47);
            this.btnFilterISBN.TabIndex = 2;
            this.btnFilterISBN.Text = "ISBN Search";
            this.btnFilterISBN.UseVisualStyleBackColor = true;
            // 
            // btnFilterAuthor
            // 
            this.btnFilterAuthor.Location = new System.Drawing.Point(40, 62);
            this.btnFilterAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterAuthor.Name = "btnFilterAuthor";
            this.btnFilterAuthor.Size = new System.Drawing.Size(300, 47);
            this.btnFilterAuthor.TabIndex = 0;
            this.btnFilterAuthor.Text = "Author Search";
            this.btnFilterAuthor.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoggedinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 702);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoggedinForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnMyPost;
        private System.Windows.Forms.Button btnMyMessage;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCreateAPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilterPrice;
        private System.Windows.Forms.Button btnFilterISBN;
        private System.Windows.Forms.Button btnFilterAuthor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.TextBox txbFilterPrice;
        private System.Windows.Forms.TextBox txbFilterISBN;
        private System.Windows.Forms.TextBox txbFilterAuthor;
    }
}

