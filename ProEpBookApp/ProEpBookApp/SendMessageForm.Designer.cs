namespace ProEpBookApp
{
    partial class SendMessageForm
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
            this.btSend = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(357, 214);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(151, 50);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(12, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(496, 196);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // SendMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProEpBookApp.Properties.Resources.Paper_Proselyte_Graphics;
            this.ClientSize = new System.Drawing.Size(520, 276);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btSend);
            this.Name = "SendMessageForm";
            this.Text = "Send a message";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}