using System.Windows.Forms;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace EmailClientGUI
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, System.EventArgs e)
        {
            var service = Connection.GetGmailService();
            var newMsg = MailSender.MessageConstructor(RecipientAddress.Text, SubjectField.Text, MessageBody.Text);
            MailSender.SendMail(newMsg);
            this.Close();
        }

        public void SetRecipientAddress(string address)
        {
            RecipientAddress.Text = address;
        }

        private void CancelMailButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
