namespace SanityArchiver
{
    partial class FileAttributesDialog
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
            this.Ok = new System.Windows.Forms.Button();
            this.HiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.ArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SystemCheckBox = new System.Windows.Forms.CheckBox();
            this.FileName = new System.Windows.Forms.Label();
            this.Attributes = new System.Windows.Forms.Label();
            this.CreationTime = new System.Windows.Forms.Label();
            this.ContainingDirectory = new System.Windows.Forms.Label();
            this.FileExtension = new System.Windows.Forms.Label();
            this.LastAccessTime = new System.Windows.Forms.Label();
            this.LastWriteTime = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Black;
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok.Location = new System.Drawing.Point(572, 225);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(221, 44);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok, nice";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // HiddenCheckBox
            // 
            this.HiddenCheckBox.AutoSize = true;
            this.HiddenCheckBox.BackColor = System.Drawing.Color.Black;
            this.HiddenCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HiddenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HiddenCheckBox.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenCheckBox.Location = new System.Drawing.Point(12, 225);
            this.HiddenCheckBox.Name = "HiddenCheckBox";
            this.HiddenCheckBox.Size = new System.Drawing.Size(125, 34);
            this.HiddenCheckBox.TabIndex = 2;
            this.HiddenCheckBox.Text = "Hidden";
            this.HiddenCheckBox.UseVisualStyleBackColor = false;
            this.HiddenCheckBox.CheckedChanged += new System.EventHandler(this.HiddenCheckBox_CheckedChanged);
            // 
            // ReadOnlyCheckBox
            // 
            this.ReadOnlyCheckBox.AutoSize = true;
            this.ReadOnlyCheckBox.BackColor = System.Drawing.Color.Black;
            this.ReadOnlyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadOnlyCheckBox.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadOnlyCheckBox.Location = new System.Drawing.Point(131, 225);
            this.ReadOnlyCheckBox.Name = "ReadOnlyCheckBox";
            this.ReadOnlyCheckBox.Size = new System.Drawing.Size(157, 34);
            this.ReadOnlyCheckBox.TabIndex = 3;
            this.ReadOnlyCheckBox.Text = "ReadOnly";
            this.ReadOnlyCheckBox.UseVisualStyleBackColor = false;
            this.ReadOnlyCheckBox.CheckedChanged += new System.EventHandler(this.ReadOnlyCheckBox_CheckedChanged);
            // 
            // ArchiveCheckBox
            // 
            this.ArchiveCheckBox.AutoSize = true;
            this.ArchiveCheckBox.BackColor = System.Drawing.Color.Black;
            this.ArchiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchiveCheckBox.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveCheckBox.Location = new System.Drawing.Point(425, 225);
            this.ArchiveCheckBox.Name = "ArchiveCheckBox";
            this.ArchiveCheckBox.Size = new System.Drawing.Size(141, 34);
            this.ArchiveCheckBox.TabIndex = 4;
            this.ArchiveCheckBox.Text = "Archive";
            this.ArchiveCheckBox.UseVisualStyleBackColor = false;
            this.ArchiveCheckBox.CheckedChanged += new System.EventHandler(this.ArchiveCheckBox_CheckedChanged);
            // 
            // SystemCheckBox
            // 
            this.SystemCheckBox.AutoSize = true;
            this.SystemCheckBox.BackColor = System.Drawing.Color.Black;
            this.SystemCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemCheckBox.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemCheckBox.Location = new System.Drawing.Point(294, 225);
            this.SystemCheckBox.Name = "SystemCheckBox";
            this.SystemCheckBox.Size = new System.Drawing.Size(125, 34);
            this.SystemCheckBox.TabIndex = 5;
            this.SystemCheckBox.Text = "System";
            this.SystemCheckBox.UseVisualStyleBackColor = false;
            this.SystemCheckBox.CheckedChanged += new System.EventHandler(this.SystemCheckBox_CheckedChanged);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.BackColor = System.Drawing.Color.Black;
            this.FileName.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(11, 9);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(153, 23);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "File name: ";
            // 
            // Attributes
            // 
            this.Attributes.AutoSize = true;
            this.Attributes.BackColor = System.Drawing.Color.Black;
            this.Attributes.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attributes.Location = new System.Drawing.Point(11, 147);
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(166, 23);
            this.Attributes.TabIndex = 7;
            this.Attributes.Text = "Attributes: ";
            // 
            // CreationTime
            // 
            this.CreationTime.AutoSize = true;
            this.CreationTime.BackColor = System.Drawing.Color.Black;
            this.CreationTime.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationTime.Location = new System.Drawing.Point(11, 55);
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.Size = new System.Drawing.Size(205, 23);
            this.CreationTime.TabIndex = 8;
            this.CreationTime.Text = "Creation time: ";
            // 
            // ContainingDirectory
            // 
            this.ContainingDirectory.AutoSize = true;
            this.ContainingDirectory.BackColor = System.Drawing.Color.Black;
            this.ContainingDirectory.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainingDirectory.Location = new System.Drawing.Point(11, 124);
            this.ContainingDirectory.Name = "ContainingDirectory";
            this.ContainingDirectory.Size = new System.Drawing.Size(296, 23);
            this.ContainingDirectory.TabIndex = 9;
            this.ContainingDirectory.Text = "Containing directory: ";
            // 
            // FileExtension
            // 
            this.FileExtension.AutoSize = true;
            this.FileExtension.BackColor = System.Drawing.Color.Black;
            this.FileExtension.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExtension.Location = new System.Drawing.Point(11, 32);
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.Size = new System.Drawing.Size(218, 23);
            this.FileExtension.TabIndex = 10;
            this.FileExtension.Text = "File extension: ";
            // 
            // LastAccessTime
            // 
            this.LastAccessTime.AutoSize = true;
            this.LastAccessTime.BackColor = System.Drawing.Color.Black;
            this.LastAccessTime.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastAccessTime.Location = new System.Drawing.Point(11, 78);
            this.LastAccessTime.Name = "LastAccessTime";
            this.LastAccessTime.Size = new System.Drawing.Size(244, 23);
            this.LastAccessTime.TabIndex = 11;
            this.LastAccessTime.Text = "Last access time: ";
            // 
            // LastWriteTime
            // 
            this.LastWriteTime.AutoSize = true;
            this.LastWriteTime.BackColor = System.Drawing.Color.Black;
            this.LastWriteTime.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastWriteTime.Location = new System.Drawing.Point(11, 101);
            this.LastWriteTime.Name = "LastWriteTime";
            this.LastWriteTime.Size = new System.Drawing.Size(218, 23);
            this.LastWriteTime.TabIndex = 12;
            this.LastWriteTime.Text = "Last write time:";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.BackColor = System.Drawing.Color.Black;
            this.Size.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(11, 170);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(88, 23);
            this.Size.TabIndex = 13;
            this.Size.Text = "Size: ";
            // 
            // FileAttributesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(805, 281);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.LastWriteTime);
            this.Controls.Add(this.LastAccessTime);
            this.Controls.Add(this.FileExtension);
            this.Controls.Add(this.ContainingDirectory);
            this.Controls.Add(this.CreationTime);
            this.Controls.Add(this.Attributes);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SystemCheckBox);
            this.Controls.Add(this.ArchiveCheckBox);
            this.Controls.Add(this.ReadOnlyCheckBox);
            this.Controls.Add(this.HiddenCheckBox);
            this.Controls.Add(this.Ok);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileAttributesDialog";
            this.Text = "FileAttributesDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.CheckBox HiddenCheckBox;
        private System.Windows.Forms.CheckBox ReadOnlyCheckBox;
        private System.Windows.Forms.CheckBox ArchiveCheckBox;
        private System.Windows.Forms.CheckBox SystemCheckBox;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label Attributes;
        private System.Windows.Forms.Label CreationTime;
        private System.Windows.Forms.Label ContainingDirectory;
        private System.Windows.Forms.Label FileExtension;
        private System.Windows.Forms.Label LastAccessTime;
        private System.Windows.Forms.Label LastWriteTime;
        private System.Windows.Forms.Label Size;
    }
}