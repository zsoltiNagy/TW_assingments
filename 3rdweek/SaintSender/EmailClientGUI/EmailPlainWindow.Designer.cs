namespace EmailClientGUI
{
    partial class EmailPlainWindow
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
            this.MailBodyBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.SenderDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MailBodyBox
            // 
            this.MailBodyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.MailBodyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailBodyBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MailBodyBox.Enabled = false;
            this.MailBodyBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailBodyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.MailBodyBox.Location = new System.Drawing.Point(20, 29);
            this.MailBodyBox.Margin = new System.Windows.Forms.Padding(4);
            this.MailBodyBox.Multiline = true;
            this.MailBodyBox.Name = "MailBodyBox";
            this.MailBodyBox.ReadOnly = true;
            this.MailBodyBox.Size = new System.Drawing.Size(876, 568);
            this.MailBodyBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = global::EmailClientGUI.Properties.Resources.quit;
            this.pictureBox1.Location = new System.Drawing.Point(844, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.QuitIcon_Click);
            // 
            // ReplyButton
            // 
            this.ReplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.ReplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.ReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.ReplyButton.Location = new System.Drawing.Point(477, 557);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(88, 40);
            this.ReplyButton.TabIndex = 2;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // SenderDetailsLabel
            // 
            this.SenderDetailsLabel.AutoSize = true;
            this.SenderDetailsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.SenderDetailsLabel.Location = new System.Drawing.Point(12, 9);
            this.SenderDetailsLabel.Name = "SenderDetailsLabel";
            this.SenderDetailsLabel.Size = new System.Drawing.Size(82, 16);
            this.SenderDetailsLabel.TabIndex = 3;
            this.SenderDetailsLabel.Text = "<unknown>";
            // 
            // EmailPlainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(914, 613);
            this.Controls.Add(this.SenderDetailsLabel);
            this.Controls.Add(this.ReplyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MailBodyBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailPlainWindow";
            this.Text = "EmailWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailBodyBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.Label SenderDetailsLabel;
    }
}