using Google.Apis.Gmail.v1;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class MainWindow : Form
    {
        List<UsersResource.MessagesResource.GetRequest> messageRequests = null;
        public MainWindow()
        {
            InitializeComponent();
            RefreshInbox();
            letterPicture.Image = Properties.Resources.logo;
            letterPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            QuitBox.Image = Properties.Resources.quit;
            QuitBox.SizeMode = PictureBoxSizeMode.Zoom;
            InitTimer();
        }

        private void QuitBox_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
