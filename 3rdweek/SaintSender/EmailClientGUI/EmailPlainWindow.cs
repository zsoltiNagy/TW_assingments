using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class EmailPlainWindow : Form
    {
        public EmailPlainWindow()
        {
            InitializeComponent();
        }

        public void FillMailBodyBox(string text)
        {
            MailBodyBox.Text = text;
        }

        public void FillSenderDetails(string details)
        {
            SenderDetailsLabel.Text = details;
        }

        private void ReplyButton_Click(object sender, System.EventArgs e)
        {
            SendEmail replyWindow = new SendEmail();
            string windowHeader = this.Text;
            string from = windowHeader.Split('<')[1].Split('>')[0];
            replyWindow.SetRecipientAddress(from);
            replyWindow.Show();
        }

        private void QuitIcon_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
