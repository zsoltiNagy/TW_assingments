namespace SanityArchiver
{
    partial class HalfCommander
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
            this.DirectoryContentBox = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CopyBox = new System.Windows.Forms.TextBox();
            this.MoveBox = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CompressButton = new System.Windows.Forms.Button();
            this.CryptButton = new System.Windows.Forms.Button();
            this.AttributesButton = new System.Windows.Forms.Button();
            this.Reporter = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectoryContentBox
            // 
            this.DirectoryContentBox.BackColor = System.Drawing.Color.Chartreuse;
            this.DirectoryContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectoryContentBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectoryContentBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DirectoryContentBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryContentBox.ForeColor = System.Drawing.Color.Black;
            this.DirectoryContentBox.FormattingEnabled = true;
            this.DirectoryContentBox.ItemHeight = 27;
            this.DirectoryContentBox.Location = new System.Drawing.Point(209, 181);
            this.DirectoryContentBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DirectoryContentBox.Name = "DirectoryContentBox";
            this.DirectoryContentBox.Size = new System.Drawing.Size(812, 297);
            this.DirectoryContentBox.TabIndex = 1;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Chartreuse;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(457, 132);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(420, 37);
            this.SearchBox.TabIndex = 4;
            // 
            // CopyBox
            // 
            this.CopyBox.BackColor = System.Drawing.Color.Chartreuse;
            this.CopyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopyBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBox.ForeColor = System.Drawing.Color.Black;
            this.CopyBox.Location = new System.Drawing.Point(344, 507);
            this.CopyBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CopyBox.Name = "CopyBox";
            this.CopyBox.Size = new System.Drawing.Size(375, 28);
            this.CopyBox.TabIndex = 5;
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Chartreuse;
            this.MoveBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveBox.ForeColor = System.Drawing.Color.Black;
            this.MoveBox.Location = new System.Drawing.Point(344, 547);
            this.MoveBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(373, 28);
            this.MoveBox.TabIndex = 6;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Black;
            this.Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.Color.Chartreuse;
            this.Open.Location = new System.Drawing.Point(209, 117);
            this.Open.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(114, 52);
            this.Open.TabIndex = 7;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Chartreuse;
            this.Back.Location = new System.Drawing.Point(333, 117);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 52);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Black;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.SearchButton.Location = new System.Drawing.Point(887, 118);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(134, 52);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Black;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.CopyButton.Location = new System.Drawing.Point(209, 503);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(125, 32);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Copy!";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.Color.Black;
            this.MoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.MoveButton.Location = new System.Drawing.Point(209, 543);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(125, 32);
            this.MoveButton.TabIndex = 11;
            this.MoveButton.Text = "Move!";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.Color.Black;
            this.CompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompressButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.CompressButton.Location = new System.Drawing.Point(31, 198);
            this.CompressButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(125, 57);
            this.CompressButton.TabIndex = 12;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = false;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // CryptButton
            // 
            this.CryptButton.BackColor = System.Drawing.Color.Black;
            this.CryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CryptButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.CryptButton.Location = new System.Drawing.Point(30, 285);
            this.CryptButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.Size = new System.Drawing.Size(121, 57);
            this.CryptButton.TabIndex = 13;
            this.CryptButton.Text = "Encrypt";
            this.CryptButton.UseVisualStyleBackColor = false;
            this.CryptButton.Click += new System.EventHandler(this.CryptButton_Click);
            // 
            // AttributesButton
            // 
            this.AttributesButton.BackColor = System.Drawing.Color.Black;
            this.AttributesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttributesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttributesButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.AttributesButton.Location = new System.Drawing.Point(30, 117);
            this.AttributesButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AttributesButton.Name = "AttributesButton";
            this.AttributesButton.Size = new System.Drawing.Size(126, 52);
            this.AttributesButton.TabIndex = 14;
            this.AttributesButton.Text = "Details";
            this.AttributesButton.UseVisualStyleBackColor = false;
            this.AttributesButton.Click += new System.EventHandler(this.AttributesButton_Click);
            // 
            // Reporter
            // 
            this.Reporter.AutoSize = true;
            this.Reporter.BackColor = System.Drawing.Color.Chartreuse;
            this.Reporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporter.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporter.ForeColor = System.Drawing.Color.Black;
            this.Reporter.Location = new System.Drawing.Point(339, 593);
            this.Reporter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Reporter.Name = "Reporter";
            this.Reporter.Size = new System.Drawing.Size(0, 27);
            this.Reporter.TabIndex = 15;
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.Black;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DecryptButton.Location = new System.Drawing.Point(30, 374);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(121, 57);
            this.DecryptButton.TabIndex = 17;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Courier New", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Chartreuse;
            this.Title.Location = new System.Drawing.Point(21, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(569, 60);
            this.Title.TabIndex = 19;
            this.Title.Text = "HalfCommander 0.1";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Black;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.QuitButton.Location = new System.Drawing.Point(978, 26);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(43, 36);
            this.QuitButton.TabIndex = 23;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(209, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Reporter:";
            // 
            // HalfCommander
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1055, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.Reporter);
            this.Controls.Add(this.AttributesButton);
            this.Controls.Add(this.CryptButton);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.CopyBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DirectoryContentBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HalfCommander";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HalfCommander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox DirectoryContentBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox CopyBox;
        private System.Windows.Forms.TextBox MoveBox;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.Button CryptButton;
        private System.Windows.Forms.Button AttributesButton;
        private System.Windows.Forms.Label Reporter;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label1;
    }
}

