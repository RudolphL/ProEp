namespace ProEpBookApp
{
    partial class PostForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.tbBIsbn = new System.Windows.Forms.TextBox();
            this.tbBAuthor = new System.Windows.Forms.TextBox();
            this.tbBPublisher = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.comboBCondition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(187, 54);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(286, 22);
            this.tbTitle.TabIndex = 0;
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(187, 82);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(286, 22);
            this.tbPlace.TabIndex = 0;
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(187, 110);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(546, 116);
            this.richDescription.TabIndex = 1;
            this.richDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Post";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Book";
            // 
            // tbBName
            // 
            this.tbBName.Location = new System.Drawing.Point(187, 297);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(286, 22);
            this.tbBName.TabIndex = 0;
            // 
            // tbBIsbn
            // 
            this.tbBIsbn.Location = new System.Drawing.Point(187, 325);
            this.tbBIsbn.Name = "tbBIsbn";
            this.tbBIsbn.Size = new System.Drawing.Size(286, 22);
            this.tbBIsbn.TabIndex = 0;
            // 
            // tbBAuthor
            // 
            this.tbBAuthor.Location = new System.Drawing.Point(187, 353);
            this.tbBAuthor.Name = "tbBAuthor";
            this.tbBAuthor.Size = new System.Drawing.Size(286, 22);
            this.tbBAuthor.TabIndex = 0;
            // 
            // tbBPublisher
            // 
            this.tbBPublisher.Location = new System.Drawing.Point(187, 381);
            this.tbBPublisher.Name = "tbBPublisher";
            this.tbBPublisher.Size = new System.Drawing.Size(286, 22);
            this.tbBPublisher.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(187, 409);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(286, 22);
            this.tbPrice.TabIndex = 0;
            // 
            // comboBCondition
            // 
            this.comboBCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCondition.FormattingEnabled = true;
            this.comboBCondition.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.comboBCondition.Location = new System.Drawing.Point(187, 437);
            this.comboBCondition.Name = "comboBCondition";
            this.comboBCondition.Size = new System.Drawing.Size(286, 24);
            this.comboBCondition.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Publishor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Condition";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePost.Location = new System.Drawing.Point(12, 512);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(797, 65);
            this.btnCreatePost.TabIndex = 5;
            this.btnCreatePost.Text = "Create Post";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 589);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.comboBCondition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbBPublisher);
            this.Controls.Add(this.tbBAuthor);
            this.Controls.Add(this.tbBIsbn);
            this.Controls.Add(this.tbBName);
            this.Controls.Add(this.tbTitle);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.TextBox tbBIsbn;
        private System.Windows.Forms.TextBox tbBAuthor;
        private System.Windows.Forms.TextBox tbBPublisher;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox comboBCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreatePost;
    }
}