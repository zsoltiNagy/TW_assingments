using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClientGUI
{
    public partial class MainWindow
    {
        public void RefreshInbox()
        {
            messageRequests = MailService.GetMessageRequestList();
            Inbox.Items.Clear();
            foreach (var req in messageRequests)
            {
                ConstructMailLine(req);
            }
        }

        private Timer RefreshInboxTimer;

        public void InitTimer()
        {
            RefreshInboxTimer = new Timer();
            RefreshInboxTimer.Tick += new EventHandler(RefreshInboxTimer_tick);
            RefreshInboxTimer.Interval = 60000; // in miliseconds
            RefreshInboxTimer.Start();
        }

        private void RefreshInboxTimer_tick(object sender, EventArgs e)
        {
            RefreshInbox();
        }
    }
}
