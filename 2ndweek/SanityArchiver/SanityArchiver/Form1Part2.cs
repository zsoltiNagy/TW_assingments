using System;
using System.Collections.Generic;
using System.IO;

namespace SanityArchiver
{
    public partial class HalfCommander {

        private void FillDirectoryContentBoxFromList(List<string> container)
        {
            DirectoryContentBox.Items.Clear();
            foreach (var item in container)
            {
                DirectoryContentBox.Items.Add(item);
            }
        }

        private void FillDirectoryContentBoxFromDir(string path)
        {
            try
            {
                currentDir = new DirectoryInfo(path);
                DirectoryContentBox.Items.Clear();
                foreach (var directory in currentDir.GetDirectories())
                {
                    DirectoryContentBox.Items.Add(directory.ToString());
                }
                foreach (var file in currentDir.GetFiles())
                {
                    DirectoryContentBox.Items.Add(file.ToString());
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Reporter.Text = e.Message;
            }
            catch (IOException f)
            {
                Reporter.Text = f.Message;
            }
        }

        private string GetPath()
        {
            return currentDir.FullName + "\\"
                    + DirectoryContentBox.SelectedItem.ToString();
        }
    }
}
