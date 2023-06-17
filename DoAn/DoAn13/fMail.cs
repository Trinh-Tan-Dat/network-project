using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using HtmlAgilityPack;
using System.Xml;
using HtmlDocument = System.Windows.Forms.HtmlDocument;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using Limilabs.Client.IMAP;
using MimeKit;
using System.Net.Mail;
using MailKit.Net.Smtp;

namespace DoAn.DoAn13
{
    public partial class fMail : Form
    {
        BackgroundWorker worker;
        public fMail()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelReadMail.Visible = false;
            panelSend.Visible = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowList();
        }

        ImapClient imapClient;
        MailKit.Net.Smtp.SmtpClient smtpClient;
        string email;
        public void connectAccount(string u, string p)
        {
            try
            {
                imapClient = new ImapClient();
                imapClient.Connect("imap.gmail.com", 993, true);
                imapClient.Authenticate(u, p);
                smtpClient = new MailKit.Net.Smtp.SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate(u, p);
                email = u;
            }
            catch
            {

            }

        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            ((fLoginEmail)Application.OpenForms["fLoginEmail"]).closeMailApp();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            imapClient.Disconnect(true);
        }

        private void butRef_Click(object sender, EventArgs e)
        {
            panelMail.Controls.Clear();
            try
            {
                worker.RunWorkerAsync();
            }
            catch { }
        }
        string ConvertHtmlToPlainText(string html)
        {
            string strippedText = StripHtmlTags(html);
            string decodedText = DecodeHtmlEntities(strippedText);

            return decodedText;
        }
        string StripHtmlTags(string html)
        {
            string strippedText = Regex.Replace(html, "<.*?>", String.Empty);
            return strippedText;
        }

        string DecodeHtmlEntities(string html)
        {
            string decodedText = System.Net.WebUtility.HtmlDecode(html);
            return decodedText;
        }
        List<usMessMail> list;
        List<InforMail> listMail;
        public void loadEmail()
        {
            list = new List<usMessMail>();
            listMail = new List<InforMail>();
            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            int j = 1;
            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 10; i--)
            {
                usMessMail u = new usMessMail();
                var message = inbox.GetMessage(i);
                var subject = message.Subject;
                var date = message.Date;
                var from = message.From;
                var num = j.ToString();
                j++;
                string body = "";

                /* if (message.TextBody != null)
                 {
                     body = message.TextBody;
                 }
                 else if (message.HtmlBody != null)
                 {
                     body = message.HtmlBody;
                     if (!message.HtmlBody.Contains("<html>") || !message.HtmlBody.Contains("<body>"))
                     {
                         body = ConvertHtmlToPlainText(body);
                     }
                     else
                     {
                         body = "<body> " + body + "</body>";
                         body = message.HtmlBody;
                     }
                 }
                 else
                 {
                     body = string.Empty;
                 }*/
                string bodytext = message.TextBody;
                body = message.HtmlBody;
                if (body == null) body = bodytext;
                InforMail im = new InforMail();
                im.set(num, from.ToString(), subject, date.ToString(), body, bodytext);
                u.setMail(subject, bodytext);
                u.set(im);
                //listMail.Add(im);
                list.Add(u);

            }

           // imapClient.Disconnect(true);

        }
        void ShowList()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                loadEmail();
                for (int i = 0; i < list.Count; i++)
                {
                    panelMail.Controls.Add(list[i]);
                    list[i].BringToFront();
                    list[i].Dock = DockStyle.Top;
                }    
            }));

        }



        private void fMail_Load(object sender, EventArgs e)
        {
            //ShowList();
            panelReadMail.Visible = false;
            worker.RunWorkerAsync();
        }

        public string mailFrom = "project.q2dcrew@gmail.com";


        private void butSend_Click(object sender, EventArgs e)
        {
            txtMailTo.Text = "";
            panelReadMail.Visible = false;
            panelSend.Visible = true;
        }
        public void ShowMail(string subject, string from, string body,string sub)
        {
            string emailfr = "", namefr = "";
            int j = 0, posx =0,posy = 0;
            for(int i =0;i<from.Length;i++ )
            {
                if (from[i] == '"')
                {
                    if (j == 0)
                        posx = i;
                    else if (j == 1)
                    {
                        posy = i;
                        break;
                    }    
                    j++;
                }
            }
            namefr = from.Substring(posx + 1, posy - posx - 1);
            for (int i = 0; i < from.Length; i++)
            {
                if (from[i] == '<')
                {
                    posx = i;
                }
                if (from[i] == '>')
                {
                    posy = i;
                }    
            }
            emailfr = from.Substring(posx + 1, posy - posx - 1);
            lbMailFrom.Text = emailfr;
            lbNameFrom.Text = namefr;
            if (IsHtmlText(body))
                webBrowser1.DocumentText = body;
                //lbBody.Text = body;
            txtSubjectShowMail.Text = sub;
        }

        private void butReply_Click(object sender, EventArgs e)
        {
            if (lbMailFrom.Text == "" || lbNameFrom.Text == "") return;
            string to = lbMailFrom.Text;
            string pattern = @"<([^>]+)>";
            Match match = Regex.Match(email, pattern);

            string from1 = "1";
            if (match.Success)
            {
                from1 = match.Groups[1].Value;

                // Lấy giá trị email từ kết quả tìm kiếm
            }
            txtMailTo.Text = to;
            panelSend.Visible = true;
            panelReadMail.Visible = false;
        }
        public static bool IsHtmlText(string input)
        {
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(input);
            return htmlDoc.DocumentNode.ChildNodes.Count > 0;
        }

        private void butSendMessage_Click_1(object sender, EventArgs e)
        {
            if (txtMailTo.Text == "" || txtSubject.Text == "") return;
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Q2D", mailFrom));
                message.To.Add(new MailboxAddress("", txtMailTo.Text));
                message.Subject = txtSubject.Text;
                if (!checkHTML.Checked)
                {
                    message.Body = new TextPart("plain")
                    {
                        Text = textMessage.Text
                    };
                }
                else
                {
                    message.Body = new TextPart("html")
                    {
                        Text = textMessage.Text
                    };
                }

                smtpClient.Send(message);
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfMessage("Email send successful", "");
                fn.ShowDialog();
                txtSubject.Text = "";
                textMessage.Text = "";

            }
            catch
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfNotiMessage(DoAn.Properties.Resources.warning_removebg_preview, "An error has occurred", "Please check again");
                fn.ShowDialog();
            }
        }

        private void textMessage_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butSendMessage.PerformClick();
                textMessage.Multiline = false;
                textMessage.Multiline = true;
            }
        }
    }
}
