using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.DoAN5
{
    public partial class fDoAn5 : Form
    {
        BackgroundWorker worker;
        public fDoAn5()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }
        private void UpdateCursor(Cursor cursor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Cursor>(UpdateCursor), cursor);
            }
            else
            {
                Cursor = cursor;
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateCursor(Cursors.Default);
            butCheck.Enabled = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateCursor(Cursors.WaitCursor);
            if (txtIP.Text == "")
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                Image img = DoAn.Properties.Resources.warning_removebg_preview;
                fn.setfNotiMessage(img, "Textbox cannot be empty", "Please input IP address");
                fn.ShowDialog();
                return;
            }
            try
            {
                string url = txtIP.Text;
                if (IsFtpServiceRunning(url))
                {
                    Notification.fNotiMessage fn = new Notification.fNotiMessage();
                    Image img = DoAn.Properties.Resources.success;
                    fn.setfNotiMessage(img, "Successful check", "FTP Service is running");
                    fn.ShowDialog();
                }
                else
                {
                    Notification.fNotiMessage fn = new Notification.fNotiMessage();
                    Image img = DoAn.Properties.Resources.warning_removebg_preview;
                    fn.setfNotiMessage(img, "Successful check", "FTP Service is down");
                    fn.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                Image img = DoAn.Properties.Resources.warning_removebg_preview;
                fn.setfNotiMessage(img, "Check failed", "Something went wrong");
                fn.ShowDialog();
            }
        }

        private void butCheck_Click(object sender, EventArgs e)
        {
            butCheck.Enabled = false;
            worker.RunWorkerAsync();
        }
        public static bool IsFtpServiceRunning(string host)
        {
            int port = 21;
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{host}:{port}");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential("anonymous", "");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butCheck.PerformClick();
            }    
        }
    }
}
