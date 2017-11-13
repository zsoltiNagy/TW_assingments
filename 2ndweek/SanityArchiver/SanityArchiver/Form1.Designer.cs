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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.DirectoryContentBox = new System.Windows.Forms.ListBox();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.PasteLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CopyBox = new System.Windows.Forms.TextBox();
            this.PasteBox = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(328, 38);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            // 
            // DirectoryContentBox
            // 
            this.DirectoryContentBox.FormattingEnabled = true;
            this.DirectoryContentBox.Location = new System.Drawing.Point(12, 38);
            this.DirectoryContentBox.Name = "DirectoryContentBox";
            this.DirectoryContentBox.Size = new System.Drawing.Size(307, 394);
            this.DirectoryContentBox.TabIndex = 1;
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Location = new System.Drawing.Point(328, 100);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(31, 13);
            this.CopyLabel.TabIndex = 2;
            this.CopyLabel.Text = "Copy";
            // 
            // PasteLabel
            // 
            this.PasteLabel.AutoSize = true;
            this.PasteLabel.Location = new System.Drawing.Point(328, 165);
            this.PasteLabel.Name = "PasteLabel";
            this.PasteLabel.Size = new System.Drawing.Size(34, 13);
            this.PasteLabel.TabIndex = 3;
            this.PasteLabel.Text = "Paste";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(328, 54);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(239, 20);
            this.SearchBox.TabIndex = 4;
            // 
            // CopyBox
            // 
            this.CopyBox.Location = new System.Drawing.Point(328, 116);
            this.CopyBox.Name = "CopyBox";
            this.CopyBox.Size = new System.Drawing.Size(239, 20);
            this.CopyBox.TabIndex = 5;
            // 
            // PasteBox
            // 
            this.PasteBox.Location = new System.Drawing.Point(328, 181);
            this.PasteBox.Name = "PasteBox";
            this.PasteBox.Size = new System.Drawing.Size(239, 20);
            this.PasteBox.TabIndex = 6;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 7;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(94, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(573, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(573, 113);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Copy!";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(573, 178);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(75, 23);
            this.PasteButton.TabIndex = 11;
            this.PasteButton.Text = "Paste!";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // HalfCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.PasteBox);
            this.Controls.Add(this.CopyBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PasteLabel);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.DirectoryContentBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "HalfCommander";
            this.Text = "HalfCommander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ListBox DirectoryContentBox;
        private System.Windows.Forms.Label CopyLabel;
        private System.Windows.Forms.Label PasteLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox CopyBox;
        private System.Windows.Forms.TextBox PasteBox;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
    }
}

