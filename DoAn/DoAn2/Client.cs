using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Caro;
using DoAn.Notification;
using Org.BouncyCastle.Bcpg;

namespace DoAn.DoAn2
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private void ScrollToBottom()
        {
            panelContentChat.AutoScrollPosition = new Point(0, panelContentChat.VerticalScroll.Maximum);
        }
        private UdpClient udpClient;
        IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        String ipAddress = "127.0.0.1";
        Thread thread;
        public void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveMess = udpClient.Receive(ref remoteEP);
                    String message = Encoding.UTF8.GetString(receiveMess);

                    if (message.ToLower() == "server: ram") message = "Server: Bộ nhớ truy xuất ngẫu nhiên";

                    this.Invoke((MethodInvoker)(() =>
                    {
                        Chat.usYourMessage c = new Chat.usYourMessage();
                        c.setLabelMessage(message);
                        c.setPicture(DoAn.Properties.Resources.server);
                        panelContentChat.Controls.Add(c);
                        c.BringToFront();
                        c.Dock = DockStyle.Top;
                        ScrollToBottom();
                    }));
                }
            }
            catch
            {
                Notification.fNotiMessage fn = new fNotiMessage();
                fn.setfNotiMessage(DoAn.Properties.Resources.warning_removebg_preview, "Server is not listening", "Please connect later");
                fn.ShowDialog();
            }
        }
        Image im = DoAn.Properties.Resources.icons8_user_male_64;
        public void setAvar(Image img)
        {
            im = img;
        }
        private void butSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "") return;

            string mess = txtMessage.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                Chat.usMyMessage c = new Chat.usMyMessage();
                c.setLabelMessage(mess);
                // c.setPicture(((fHome)Application.OpenForms["fHome"]).butAvarta.Image);
                c.setPicture(im);
                panelContentChat.Controls.Add(c);
                c.BringToFront();
                c.Dock = DockStyle.Top;
                ScrollToBottom();
                txtMessage.Text = "";
                txtMessage.Select();
                txtMessage.Multiline = false;
                txtMessage.Multiline = true;
                txtMessage.Clear();
            }));

            serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(mess);




            udpClient.Send(sendBytes, sendBytes.Length, serverEndpoint);

            //
            Thread.Sleep(200);
            thread = new Thread(new ThreadStart(ReceiveMessage));
            thread.Start();

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread?.Interrupt();
            thread?.Abort();
            udpClient?.Close();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butSend.PerformClick();
            }    
        }

        private void Client_Load(object sender, EventArgs e)
        {
            txtMessage.Select();
        }
    }
}
