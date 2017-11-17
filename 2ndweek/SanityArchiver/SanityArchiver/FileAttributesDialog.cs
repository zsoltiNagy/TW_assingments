using System;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class FileAttributesDialog : Form
    {
        string path;
        public FileAttributesDialog()
        {
            InitializeComponent();
        }

        public void SetDialogContent(string path)
        {
            this.path = path;
            if (!FileHandler.IsDirectory(path))
            {
                FileInfo file = new FileInfo(path);

                FileName.Text += file.Name;
                Attributes.Text += file.Attributes;
                CreationTime.Text += file.CreationTime;
                ContainingDirectory.Text += file.DirectoryName;
                FileExtension.Text += file.Extension;
                LastAccessTime.Text += file.LastAccessTime;
                LastWriteTime.Text += file.LastWriteTime;
                Size.Text += FileHandler.SizeConverter(file.Length);

                SetCheckBoxes(path);
            } else
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileName.Text += dir.Name;
                Attributes.Text += dir.Attributes;
                CreationTime.Text += dir.CreationTime;
                ContainingDirectory.Text += dir.Parent.Name;
                FileExtension.Text = "Number of files contained: " + dir.GetFiles().Length;
                LastAccessTime.Text += dir.LastAccessTime;
                LastWriteTime.Text += dir.LastWriteTime;
                Size.Text += FileHandler.SizeConverter(FileHandler.DirectorySize(dir));

                SetCheckBoxes(path);
            }
        }

        private void SetCheckBoxes(string path)
        {
            FileAttributes attributes = File.GetAttributes(path);
            HiddenCheckBox.Checked = ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden);
            ArchiveCheckBox.Checked = ((attributes & FileAttributes.Archive) == FileAttributes.Archive);
            SystemCheckBox.Checked = ((attributes & FileAttributes.System) == FileAttributes.System);
            ReadOnlyCheckBox.Checked = ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HiddenCheckBox.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
            } else
            {
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.Hidden);
            }
        }

        private void ReadOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadOnlyCheckBox.Checked)
            {
                FileInfo file = new FileInfo(path);
                file.IsReadOnly = true;
            }
            else
            {
                FileInfo file = new FileInfo(path);
                file.IsReadOnly = false;
            }
        }

        private void ArchiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ArchiveCheckBox.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Archive);
            }
            else
            {
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.Archive);
            }
        }

        private void SystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SystemCheckBox.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.System);
            }
            else
            {
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.System);
            }
        }

        private string FileReader(FileInfo file)
        {
            return "";
        }
    }
}
