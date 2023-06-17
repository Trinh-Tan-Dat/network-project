using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;

namespace DoAn.DoAn13
{
    public partial class fLoginEmail : Form
    {
        public fLoginEmail()
        {
            InitializeComponent();
        }
        ImapClient imapClient;
        public bool connectAccount(string u, string p)
        {
            try
            {
                imapClient = new ImapClient();
                imapClient.Connect("imap.gmail.com", 993, true);
                imapClient.Authenticate(u.Trim(), p.Trim());
            }
            catch
            {
                return false;
            }
            return true;
        }
        fMail f;
        public void closeMailApp()
        {
            if (f!=null)
                f.Close();
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (connectAccount(textUser.Text, textPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                f = new fMail();
                f.connectAccount(textUser.Text, textPassword.Text);
                f.ShowDialog();
                imapClient.Disconnect(true);
            }   
            else
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfNotiMessage(DoAn.Properties.Resources.warning_removebg_preview,"Can not connect","Please check your account");
                fn.ShowDialog();
                this.DialogResult = DialogResult.Cancel;
            }    
        }
    }
}
