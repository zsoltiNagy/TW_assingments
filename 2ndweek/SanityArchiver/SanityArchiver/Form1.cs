using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class HalfCommander : Form
    {
        string baseRootPath;
        DirectoryInfo currentDir;
        string copyDir;

        public HalfCommander()
        {
            InitializeComponent();
            baseRootPath = @"C:\";
            FillDirectoryContentBox(@"C:\Users\Zsolt Nagy\dotNET");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string path = currentDir.FullName + "\\" + DirectoryContentBox.SelectedItem.ToString();
            FillDirectoryContentBox(path);
        }

        private void FillDirectoryContentBox(string path)
        {
            DirectoryContentBox.Items.Clear();
            currentDir = new DirectoryInfo(path);
            Console.WriteLine(path);
            foreach (var directory in currentDir.GetDirectories()) {
                    DirectoryContentBox.Items.Add(directory.ToString());
            }
            foreach (var file in currentDir.GetFiles())
            {
                DirectoryContentBox.Items.Add(file.ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                FillDirectoryContentBox(currentDir.Parent.FullName);
            }
            catch (NullReferenceException)
            {
                FillDirectoryContentBox(baseRootPath);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            copyDir = DirectoryContentBox.SelectedItem.ToString();
            CopyBox.Text = currentDir.FullName + "\\" + copyDir;
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            Directory.Move(CopyBox.Text, currentDir.FullName + "\\" + copyDir);
            CopyBox.Text = "";
            FillDirectoryContentBox(currentDir.FullName);
        }
    }
}
