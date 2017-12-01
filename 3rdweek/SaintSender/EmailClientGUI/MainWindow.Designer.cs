namespace EmailClientGUI
{
    partial class MainWindow
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
            this.OpenPlainButton = new System.Windows.Forms.Button();
            this.SnippetBox = new System.Windows.Forms.TextBox();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.OpenHTMLButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Label();
            this.Inbox = new System.Windows.Forms.ListView();
            this.letterPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenPlainButton
            // 
            this.OpenPlainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.OpenPlainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPlainButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.OpenPlainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPlainButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPlainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.OpenPlainButton.Location = new System.Drawing.Point(12, 379);
            this.OpenPlainButton.Name = "OpenPlainButton";
            this.OpenPlainButton.Size = new System.Drawing.Size(161, 55);
            this.OpenPlainButton.TabIndex = 0;
            this.OpenPlainButton.Text = "Open Plain Text";
            this.OpenPlainButton.UseVisualStyleBackColor = false;
            this.OpenPlainButton.Click += new System.EventHandler(this.OpenPlainButton_Click);
            // 
            // SnippetBox
            // 
            this.SnippetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.SnippetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SnippetBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SnippetBox.Enabled = false;
            this.SnippetBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnippetBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.SnippetBox.Location = new System.Drawing.Point(341, 116);
            this.SnippetBox.Multiline = true;
            this.SnippetBox.Name = "SnippetBox";
            this.SnippetBox.ReadOnly = true;
            this.SnippetBox.Size = new System.Drawing.Size(310, 60);
            this.SnippetBox.TabIndex = 2;
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.SenderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.SenderLabel.Location = new System.Drawing.Point(342, 213);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(26, 18);
            this.SenderLabel.TabIndex = 3;
            this.SenderLabel.Text = "<>";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.DateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.DateLabel.Location = new System.Drawing.Point(342, 276);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(26, 18);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "<>";
            // 
            // OpenHTMLButton
            // 
            this.OpenHTMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.OpenHTMLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenHTMLButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.OpenHTMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenHTMLButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenHTMLButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.OpenHTMLButton.Location = new System.Drawing.Point(179, 379);
            this.OpenHTMLButton.Name = "OpenHTMLButton";
            this.OpenHTMLButton.Size = new System.Drawing.Size(147, 55);
            this.OpenHTMLButton.TabIndex = 5;
            this.OpenHTMLButton.Text = "Open HTML Version";
            this.OpenHTMLButton.UseVisualStyleBackColor = false;
            this.OpenHTMLButton.Click += new System.EventHandler(this.OpenHTMLButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(103)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.SendButton.Location = new System.Drawing.Point(526, 381);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(125, 53);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send New Mail";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(338, 257);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(0, 13);
            this.Test.TabIndex = 7;
            // 
            // Inbox
            // 
            this.Inbox.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Inbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.Inbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Inbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.Inbox.Location = new System.Drawing.Point(12, 116);
            this.Inbox.MultiSelect = false;
            this.Inbox.Name = "Inbox";
            this.Inbox.Size = new System.Drawing.Size(314, 257);
            this.Inbox.TabIndex = 8;
            this.Inbox.UseCompatibleStateImageBehavior = false;
            this.Inbox.View = System.Windows.Forms.View.List;
            this.Inbox.SelectedIndexChanged += new System.EventHandler(this.Inbox_SelectedIndexChanged);
            // 
            // letterPicture
            // 
            this.letterPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterPicture.Location = new System.Drawing.Point(12, 12);
            this.letterPicture.Name = "letterPicture";
            this.letterPicture.Size = new System.Drawing.Size(90, 80);
            this.letterPicture.TabIndex = 9;
            this.letterPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "SaintReciever";
            // 
            // QuitBox
            // 
            this.QuitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitBox.InitialImage = global::EmailClientGUI.Properties.Resources.quit;
            this.QuitBox.Location = new System.Drawing.Point(568, 12);
            this.QuitBox.Name = "QuitBox";
            this.QuitBox.Size = new System.Drawing.Size(83, 80);
            this.QuitBox.TabIndex = 12;
            this.QuitBox.TabStop = false;
            this.QuitBox.Click += new System.EventHandler(this.QuitBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(341, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(341, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(663, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterPicture);
            this.Controls.Add(this.Inbox);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.OpenHTMLButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.SnippetBox);
            this.Controls.Add(this.OpenPlainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "SaintReciever";
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPlainButton;
        private System.Windows.Forms.TextBox SnippetBox;
        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button OpenHTMLButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.ListView Inbox;
        private System.Windows.Forms.PictureBox letterPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox QuitBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

