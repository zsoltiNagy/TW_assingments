namespace WindowsFormsApp2
{
    partial class ProcessNote
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.RunningProgressBox = new System.Windows.Forms.ListBox();
            this.idField = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.SaveCommentBox = new System.Windows.Forms.CheckBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.memoryUsage = new System.Windows.Forms.Label();
            this.totalProcessorTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunningProgressBox
            // 
            this.RunningProgressBox.BackColor = System.Drawing.Color.LightGray;
            this.RunningProgressBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningProgressBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RunningProgressBox.FormattingEnabled = true;
            this.RunningProgressBox.ItemHeight = 21;
            this.RunningProgressBox.Location = new System.Drawing.Point(11, 11);
            this.RunningProgressBox.Margin = new System.Windows.Forms.Padding(2);
            this.RunningProgressBox.Name = "RunningProgressBox";
            this.RunningProgressBox.Size = new System.Drawing.Size(419, 361);
            this.RunningProgressBox.TabIndex = 2;
            this.RunningProgressBox.Click += new System.EventHandler(this.RunningProgressBox_Click);
            // 
            // idField
            // 
            this.idField.AutoSize = true;
            this.idField.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(476, 38);
            this.idField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(40, 16);
            this.idField.TabIndex = 3;
            this.idField.Text = "    ";
            // 
            // nameField
            // 
            this.nameField.AutoSize = true;
            this.nameField.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(491, 53);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(32, 16);
            this.nameField.TabIndex = 4;
            this.nameField.Text = "   ";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // SaveCommentBox
            // 
            this.SaveCommentBox.AutoSize = true;
            this.SaveCommentBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommentBox.Location = new System.Drawing.Point(642, 364);
            this.SaveCommentBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCommentBox.Name = "SaveCommentBox";
            this.SaveCommentBox.Size = new System.Drawing.Size(110, 18);
            this.SaveCommentBox.TabIndex = 0;
            this.SaveCommentBox.Text = "Save Comment";
            this.SaveCommentBox.UseVisualStyleBackColor = true;
            this.SaveCommentBox.CheckedChanged += new System.EventHandler(this.SaveCommentBox_CheckedChanged);
            // 
            // commentBox
            // 
            this.commentBox.BackColor = System.Drawing.Color.LightGray;
            this.commentBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.commentBox.Location = new System.Drawing.Point(442, 234);
            this.commentBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(310, 114);
            this.commentBox.TabIndex = 5;
            // 
            // memoryUsage
            // 
            this.memoryUsage.AutoSize = true;
            this.memoryUsage.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryUsage.Location = new System.Drawing.Point(439, 146);
            this.memoryUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memoryUsage.Name = "memoryUsage";
            this.memoryUsage.Size = new System.Drawing.Size(32, 16);
            this.memoryUsage.TabIndex = 7;
            this.memoryUsage.Text = "   ";
            // 
            // totalProcessorTime
            // 
            this.totalProcessorTime.AutoSize = true;
            this.totalProcessorTime.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProcessorTime.Location = new System.Drawing.Point(439, 103);
            this.totalProcessorTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalProcessorTime.Name = "totalProcessorTime";
            this.totalProcessorTime.Size = new System.Drawing.Size(32, 16);
            this.totalProcessorTime.TabIndex = 6;
            this.totalProcessorTime.Text = "   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Processor Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Memory usage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "StartTime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(439, 197);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "CPU Usage:";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Location = new System.Drawing.Point(531, 71);
            this.startTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(32, 16);
            this.startTime.TabIndex = 16;
            this.startTime.Text = "   ";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threads.Location = new System.Drawing.Point(439, 180);
            this.threads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(32, 16);
            this.threads.TabIndex = 17;
            this.threads.Text = "   ";
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsage.Location = new System.Drawing.Point(439, 214);
            this.cpuUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(32, 16);
            this.cpuUsage.TabIndex = 18;
            this.cpuUsage.Text = "   ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(436, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "Proccess Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete Comment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteCommentButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 22;
            this.button3.Text = "Threads";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ThreadsButton_Click);
            // 
            // ProcessNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(435, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.memoryUsage);
            this.Controls.Add(this.totalProcessorTime);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.RunningProgressBox);
            this.Controls.Add(this.SaveCommentBox);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessNote";
            this.Text = "Running Processes";
            this.Load += new System.EventHandler(this.ListAll_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox RunningProgressBox;
        private System.Windows.Forms.Label idField;
        private System.Windows.Forms.Label nameField;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label memoryUsage;
        private System.Windows.Forms.Label totalProcessorTime;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.CheckBox SaveCommentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.Label threads;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button3;
    }
}

