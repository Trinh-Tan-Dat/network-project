using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using DoAn.Notification;
using System.Drawing;

namespace DoAn.DoAn2
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        UdpClient udpClient;
        private void ScrollToBottom()
        {
            panelMessClient.AutoScrollPosition = new Point(0, panelMessClient.VerticalScroll.Maximum);
        }
        public void serverThread()
        {
            udpClient = new UdpClient(8080);

            while (true)
            {
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                byte[] receiveBytes = udpClient.Receive(ref remoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = remoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                InfoMessage(mess);

                string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                    "en", "vi", Uri.EscapeUriString(mess));
                HttpClient httpClient = new HttpClient();
                string result = httpClient.GetStringAsync(url).Result;

                JArray jsonData = JArray.Parse(result);
                var translationItems = jsonData[0];
                string translation = "";

                foreach (var item in translationItems)
                {
                    var translationLineObject = item.First;
                    translation += $" {translationLineObject}";
                }

                if (translation.Length > 1) { translation = translation.Substring(1); }
                translation = translation.Replace("127.0.0.1:", "").Trim();
                translation = translation.Substring(0,1).ToUpper() + translation.Substring(1,translation.Length - 1);
                byte[] responseData = Encoding.UTF8.GetBytes("Server: " + translation);
                udpClient.Send(responseData, responseData.Length, remoteIpEndPoint);
            }
        }
        public void InfoMessage(String mess)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                mess = mess.Replace("127.0.0.1:", "").Trim();
                mess = "127.0.0.1: " + mess;
                Chat.usYourMessage c = new Chat.usYourMessage();
                c.setLabelMessage(mess);
                c.setPicture(DoAn.Properties.Resources.server);
                panelMessClient.Controls.Add(c);
                c.BringToFront();
                c.Dock = DockStyle.Top;
                ScrollToBottom();
            }));
        }
        Thread thdUDPServer;

        private void butStart_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            butStart.Enabled = false;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient?.Close();
            thdUDPServer?.Interrupt();
            thdUDPServer?.Abort();
        }
    }
}
