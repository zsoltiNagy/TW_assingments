using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ProcessNote : Form
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        private static Process currentProcess;
        Timer timer;
        string comment;
        private Dictionary<int, string> commentContainer = new Dictionary<int, string>();
        private static Process[] runningProcesses;
        int id;

        public ProcessNote()
        {
            InitializeComponent();
        }

        public static Process GetCurrentProcess()
        {
            return currentProcess;
        }
        
        private void ListAll_click(object sender, EventArgs e)
        {
            runningProcesses = Process.GetProcesses();
            foreach (var process in runningProcesses)
            {
                string space = String.Concat(Enumerable.Repeat(" ", 10 - process.Id.ToString().Length));
                RunningProgressBox.Items.Add(process.Id.ToString() + space + process.ProcessName.ToString());
            }
        }

        private void RunningProgressBox_Click(object sender, EventArgs e)
        {
            SaveCommentBox.Checked = false;
            this.Width = 800;
            var processLine = RunningProgressBox.SelectedItem.ToString().Split(' ');
            id = Int32.Parse(processLine[0]);
            var name = processLine[processLine.Length - 1];
            idField.Text = id.ToString();
            nameField.Text = name;
            currentProcess = Process.GetProcessById(id); ;
            try
            {
                startTime.Text = currentProcess.StartTime.ToString();
            } catch (Win32Exception)
            {
                startTime.Text = "9!";
            }

            if (commentContainer.ContainsKey(id))
            {
                commentBox.Text = commentContainer[id];
            }
            else
            {
                commentBox.Text = "";
            }
            ramCounter = new PerformanceCounter("Process", "Working Set", currentProcess.ProcessName);
            cpuCounter = new PerformanceCounter("Process", "% Processor Time", currentProcess.ProcessName);
            timer = new Timer
            {
                Interval = 1000,
            };
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();
        }

        private void SaveCommentBox_CheckedChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(idField.Text);
            if (!string.IsNullOrWhiteSpace(commentBox.Text))
            {
                try
                {
                    commentContainer.Add(id, commentBox.Text);
                }
                catch (ArgumentException)
                {
                    commentContainer[id] += commentBox.Text;
                }
            }
        }

        private void DeleteCommentButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idField.Text);
            if (commentContainer.ContainsKey(id))
            {
                commentContainer.Remove(id);
                commentBox.Text = "";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cpuUsage.Text = cpuCounter.NextValue()/Environment.ProcessorCount + "%";
            memoryUsage.Text = ramCounter.NextValue() / 1024 / 1024 +"MB";
            try
            {
                totalProcessorTime.Text = currentProcess.TotalProcessorTime.ToString();
            }
            catch (Win32Exception)
            {
                totalProcessorTime.Text = "9!";
            }
            comment = commentBox.Text;
        }

        private void ThreadsButton_Click(object sender, EventArgs e)
        {
            Threads popup = new Threads();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
    }
}
