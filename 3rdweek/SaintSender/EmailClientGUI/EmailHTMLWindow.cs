using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class EmailHTMLWindow : Form
    {
        public EmailHTMLWindow()
        {
            InitializeComponent();
        }

        public void FillBrowser(string HTMLtext)
        {
            Browser.DocumentText = HTMLtext;
        }

        private void ReplyButton_Click(object sender, System.EventArgs e)
        {
            SendEmail replyWindow = new SendEmail();
            string windowHeader = this.Text;
            string from = windowHeader.Split('<')[1].Split('>')[0];
            replyWindow.SetRecipientAddress(from);
            replyWindow.Show();
        }

        public void FillSenderDetails(string details)
        {
            SenderDetailsLabel.Text = details;
        }

        private void QuitIcon_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
