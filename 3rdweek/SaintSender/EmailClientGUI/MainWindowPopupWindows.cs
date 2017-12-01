using System;
using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class MainWindow
    {
        private void OpenPlainButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmailPlainWindow emailWindow = new EmailPlainWindow();
                var req = GetSelectedItemReqById();
                emailWindow.FillMailBodyBox(MailService.GetMessageBodyPlain(req));
                emailWindow.FillSenderDetails(MailService.GetEmailWindowHeader(req));
                emailWindow.Text = MailService.GetEmailWindowHeader(req);
                emailWindow.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("First select a mail to view by clicking on its subject.");
            }
            catch (ArgumentOutOfRangeException)
            {
                NoMailSelectedWarning();
            }
        }

        private void OpenHTMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmailHTMLWindow emailWindow = new EmailHTMLWindow();
                var req = GetSelectedItemReqById();
                emailWindow.FillBrowser(MailService.GetMessageBodyHtml(req));
                emailWindow.FillSenderDetails(MailService.GetEmailWindowHeader(req));
                emailWindow.Text = MailService.GetEmailWindowHeader(req);
                emailWindow.Show();
            }
            catch (NullReferenceException m)
            {
                NoMailSelectedWarning();
                MessageBox.Show(m.Message);
                MessageBox.Show(m.StackTrace);
            }
            catch (ArgumentOutOfRangeException n)
            {
                NoMailSelectedWarning();
                MessageBox.Show(n.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendEmail email = new SendEmail();
            email.ShowDialog();
            if (email.DialogResult == DialogResult.OK) // Test result.
            {
                Test.Text = "Nice!";
            }
        }
    }
}
