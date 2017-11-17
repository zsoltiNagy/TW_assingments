using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class HalfCommander : Form
    {
        string drivePath;
        string copyDir;
        DirectoryInfo currentDir;
        DirectoryInfo drive;

        public HalfCommander()
        {
            InitializeComponent();
            drivePath = @"C:\";
            drive = new DirectoryInfo(drivePath);
            FillDirectoryContentBoxFromDir(@"C:\Users\Zsolt Nagy\dotNET");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetPath();
                if (!FileHandler.IsDirectory(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    Process.Start(fileInfo.FullName);                   
                }
                else
                {
                    FillDirectoryContentBoxFromDir(path);
                }
            } catch (NullReferenceException)
            {
                Reporter.Text = "You should select something first.";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                FillDirectoryContentBoxFromDir(currentDir.Parent.FullName);
            }
            catch (NullReferenceException)
            {
                FillDirectoryContentBoxFromDir(drivePath);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            copyDir = DirectoryContentBox.SelectedItem.ToString();
            CopyBox.Text = currentDir.FullName + "\\" + copyDir;
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Move(CopyBox.Text, currentDir.FullName + "\\" + copyDir);
            } catch (IOException m)
            {
                Reporter.Text = m.Message;
            }
            CopyBox.Text = "";
            FillDirectoryContentBoxFromDir(currentDir.FullName);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DirectoryContentBox.Items.Clear();
            List<string> results = new List<string>();
            FileHandler.root = currentDir.FullName;
            FillDirectoryContentBoxFromList(FileHandler.RecursiveSearch(SearchBox.Text, currentDir, results));
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(GetPath());
                FileHandler.ArchiveFile(currentDir, fileInfo);
                Reporter.Text = "Succesfully compressed " + GetPath();
            }
            catch (UnauthorizedAccessException m)
            {
                Console.WriteLine(m.Message);
                Reporter.Text = "Compress unsuccesfull.";
            }
            catch (NullReferenceException n)
            {
                Reporter.Text = n.Message;
            }
            FillDirectoryContentBoxFromDir(currentDir.FullName);
        }

        private void CryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Encrypt(GetPath());
                Reporter.Text = "Succesfully encrypted " + GetPath();
            } 
            catch (UnauthorizedAccessException) {
                Reporter.Text = "Encryption unsuccesfull";
            }
            catch (IOException m)
            {
                Reporter.Text = m.Message;
            } catch (NullReferenceException n)
            {
                Reporter.Text = n.Message;
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Decrypt(GetPath());
                Reporter.Text = "Succesfully decrypted " + GetPath();
            }
            catch (UnauthorizedAccessException)
            {
                Reporter.Text = "Decryption unsuccesfull";
            }
            catch (IOException m)
            {
                Reporter.Text = m.Message;
            }
            catch (NullReferenceException n)
            {
                Reporter.Text = n.Message;
            }
        }

        private void AttributesButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileAttributesDialog fileAttributesDialog = new FileAttributesDialog();
                fileAttributesDialog.SetDialogContent(GetPath());
                fileAttributesDialog.Show();
            }
            catch (FileNotFoundException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.Message);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
