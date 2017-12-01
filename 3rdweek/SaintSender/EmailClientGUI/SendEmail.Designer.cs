namespace EmailClientGUI
{
    partial class SendEmail
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
            this.MessageBody = new System.Windows.Forms.TextBox();
            this.RecipientAddress = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CancelMailButton = new System.Windows.Forms.Button();
            this.SubjectField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBody
            // 
            this.MessageBody.Location = new System.Drawing.Point(13, 151);
            this.MessageBody.Multiline = true;
            this.MessageBody.Name = "MessageBody";
            this.MessageBody.Size = new System.Drawing.Size(550, 255);
            this.MessageBody.TabIndex = 0;
            // 
            // RecipientAddress
            // 
            this.RecipientAddress.Location = new System.Drawing.Point(14, 82);
            this.RecipientAddress.Name = "RecipientAddress";
            this.RecipientAddress.Size = new System.Drawing.Size(549, 20);
            this.RecipientAddress.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.SendButton.Location = new System.Drawing.Point(16, 413);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(165, 33);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CancelMailButton
            // 
            this.CancelMailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.CancelMailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelMailButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelMailButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.CancelMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelMailButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelMailButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.CancelMailButton.Location = new System.Drawing.Point(395, 413);
            this.CancelMailButton.Name = "CancelMailButton";
            this.CancelMailButton.Size = new System.Drawing.Size(167, 33);
            this.CancelMailButton.TabIndex = 3;
            this.CancelMailButton.Text = "Cancel";
            this.CancelMailButton.UseVisualStyleBackColor = false;
            this.CancelMailButton.Click += new System.EventHandler(this.CancelMailButton_Click);
            // 
            // SubjectField
            // 
            this.SubjectField.Location = new System.Drawing.Point(13, 125);
            this.SubjectField.Name = "SubjectField";
            this.SubjectField.Size = new System.Drawing.Size(549, 20);
            this.SubjectField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = global::EmailClientGUI.Properties.Resources.quit;
            this.pictureBox1.Location = new System.Drawing.Point(520, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = global::EmailClientGUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(16, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(77, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 56);
            this.label3.TabIndex = 9;
            this.label3.Text = "SaintSender";
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(580, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectField);
            this.Controls.Add(this.CancelMailButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.RecipientAddress);
            this.Controls.Add(this.MessageBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendEmail";
            this.Text = "SendEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBody;
        private System.Windows.Forms.TextBox RecipientAddress;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CancelMailButton;
        private System.Windows.Forms.TextBox SubjectField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}