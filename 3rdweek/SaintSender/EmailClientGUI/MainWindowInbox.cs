using Google.Apis.Gmail.v1;
using System;
using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class MainWindow
    {
        public void ConstructMailLine(UsersResource.MessagesResource.GetRequest req)
        {
            // Construct the ListViewItem object
            string text = "(no subject)";
            foreach (var header in MailService.GetMessageHeaders(req))
            {
                if (header.Name.Equals("Subject") && header.Value.Length > 0)
                {
                    text = header.Value;
                    break;
                }
            }
            ListViewItem item = new ListViewItem(text);
            item.Tag = req.Id;
            Inbox.Items.Add(item);
        }

        private UsersResource.MessagesResource.GetRequest GetSelectedItemReqById()
        {
            UsersResource.MessagesResource.GetRequest reqResult = null;
            try
            {
                ListViewItem listViewItem = Inbox.SelectedItems[0] as ListViewItem;
                string id = listViewItem.Tag.ToString();
                foreach (var req in messageRequests)
                {
                    if (req.Id.Equals(id))
                    {
                        reqResult = req;
                        break;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            return reqResult;
        }

        private void NoMailSelectedWarning()
        {
            MessageBox.Show("First select a mail to view by clicking on its subject.");
        }

        private void Inbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = Inbox.SelectedItems[0] as ListViewItem;
                string id = listViewItem.Tag.ToString();
                foreach (var req in messageRequests)
                {
                    if (req.Id.Equals(id))
                    {
                        foreach (var header in MailService.GetMessageHeaders(req))
                        {
                            if (header.Name.Equals("Received"))
                            {
                                DateLabel.Text = header.Value.Substring(header.Value.Length - 31, 18);
                            }
                        }
                        SnippetBox.Text = MailService.GetMessageSnippet(req);
                        SenderLabel.Text = MailService.GetMessageHeaders(req)[6].Value;
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
