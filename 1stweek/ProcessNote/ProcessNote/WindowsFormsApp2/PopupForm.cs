using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Threads : Form
    {
        Process currentProcess;

        public Threads()
        {
            InitializeComponent();
            threadBox.Items.Add("Id:          " + "State:       " 
                + "     StartTime:                      " + "ProcessorTime:      ");
            currentProcess = ProcessNote.GetCurrentProcess();
            ProcessThreadCollection currentThreads = currentProcess.Threads;
            foreach (ProcessThread thread in currentThreads)
            {
                threadBox.Items.Add(thread.Id + SpaceGenerator(thread.Id.ToString())
                    + thread.ThreadState + SpaceGenerator(thread.ThreadState.ToString())
                    + "       " + thread.StartTime + "       "
                    + thread.TotalProcessorTime);
            }
        }

        private object GetCurrentProcess()
        {
            throw new NotImplementedException();
        }

        public string SpaceGenerator(string spaceHolder)
        {
                return String.Concat(Enumerable.Repeat(" ", 10 - spaceHolder.Length));
        }
    }
}
