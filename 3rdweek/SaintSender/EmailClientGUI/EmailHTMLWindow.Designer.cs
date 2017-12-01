namespace EmailClientGUI
{
    partial class EmailHTMLWindow
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
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SenderDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(749, 469);
            this.Browser.TabIndex = 0;
            // 
            // ReplyButton
            // 
            this.ReplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.ReplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.ReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyButton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.ReplyButton.Location = new System.Drawing.Point(311, 420);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(114, 37);
            this.ReplyButton.TabIndex = 1;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = global::EmailClientGUI.Properties.Resources.quit;
            this.pictureBox1.Location = new System.Drawing.Point(687, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.QuitIcon_Click);
            // 
            // SenderDetailsLabel
            // 
            this.SenderDetailsLabel.AutoSize = true;
            this.SenderDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SenderDetailsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.SenderDetailsLabel.Location = new System.Drawing.Point(-3, 0);
            this.SenderDetailsLabel.Name = "SenderDetailsLabel";
            this.SenderDetailsLabel.Size = new System.Drawing.Size(82, 16);
            this.SenderDetailsLabel.TabIndex = 4;
            this.SenderDetailsLabel.Text = "<unknown>";
            // 
            // EmailHTMLWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 469);
            this.Controls.Add(this.SenderDetailsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReplyButton);
            this.Controls.Add(this.Browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailHTMLWindow";
            this.Text = "EmailHTMLWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SenderDetailsLabel;
    }
}