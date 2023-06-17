using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlTypes;
using DoAn.Notification;

namespace DoAn.Caro
{
    public partial class fCaro : Form
    {
        classCaroBoard CaroBoard;
        public SocketConnection socket;
        public SocketConnection socket2;

        public bool ishost = false;
        public bool isStart = false;
        public string GetLocalIPv4()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        int getInforGame()
        {
            int a = 5;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = CommandType.Text;
            string cmd ="select timeplay from Room where username ='" + ((fHome)Application.OpenForms["fHome"]).fTabGame.user + "'";
            SqlCmd.CommandText = cmd;
            SqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = SqlCmd.ExecuteReader();
            if (reader.Read())
            {
                a = reader.GetInt32(0);
            }
            reader.Close();
            return a;
        }
        BackgroundWorker worker;
        public fCaro()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            Control.CheckForIllegalCrossThreadCalls = false;
            PictureBox pictureBox1 = new PictureBox();
            Label lbcrt = new Label();
            CaroBoard = new classCaroBoard(panelCaroBoard, lbcrt, pictureBox1);
            CaroBoard.EndedGame += CaroBoard_EndedGame;
            CaroBoard.Playermarked += CaroBoard_PlayerMarked;
            socket = new SocketConnection();

            NewGame();
        }


        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            usWaiting1.Visible = false;
        }
        string ipconnect; // ip lấy  từ csdl kết nối tời sv
        string ipServer; // ip để làm sv
        public bool isServer;
        bool checkConnect2Soc = true;
        bool onHost;
        int tG;
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            timeRemainM = getInforGame() * 60; // Quy đổi ra giây
            timeRemainY = timeRemainM;
            tG = getInforGame() * 60;

            socket = new SocketConnection();
            socket2 = new SocketConnection();

            string user = ((fHome)Application.OpenForms["fHome"]).fTabGame.user;
            ipServer = socket.GetLocalIPv4();  //Lấy ip của người tạo room
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string cmd = "select top 1 ipadd from Room where username = '" + user + "'"; 
            sqlCmd.CommandText = cmd;
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                ipconnect = reader.GetString(0);
            }
            reader.Close();
            checkConnect2Soc = true;
            if (ipconnect != ipServer)
                onHost = false;
            else onHost = true;
            // Kiểm tra nếu không phải là máy chủ và địa chỉ IP khác nhau
            if (!isServer && checkConnect2Soc)
            {
                try
                {
                    if (onHost)
                    {
                        socket.IP = "127.0.0.1";
                        socket.setPort(30001);
                    }
                    else
                    {
                        socket.IP = ipconnect;
                        socket.setPort(30000);
                    }
                    panelNoti.Visible = false;
                    socket.ConnectServer();
                    cmd = "update Room set isbusy ='true' where username ='" + user + "'";
                    sqlCmd.CommandText = cmd;
                    sqlCmd.ExecuteNonQuery();
                    cmd = "select lastname, userimage from UserInfor where username ='" + user + "'";
                    sqlCmd.CommandText = cmd;
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        labelYourName.Text = reader.GetString(0);
                        labelChatUser.Text = labelYourName.Text;
                        byte[] imgBytes = (byte[])reader["userimage"];
                        if (imgBytes != null && imgBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pictureYour.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    reader.Close();
                    labelYourUsername.Text ="User: " + user;
                    cmd = "select lastname, userimage from UserInfor where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                    sqlCmd.CommandText = cmd;
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        labelMyName.Text = reader.GetString(0);
                        byte[] imgBytes = (byte[])reader["userimage"];
                        if (imgBytes != null && imgBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pictureMe.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    reader.Close();
                    pictureMyMark.Image = CaroBoard.Player[1].Mark;
                    pictureYourMark.Image = CaroBoard.Player[0].Mark;
                    labelMyUsername.Text ="User: "+ ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;
                    butStart.Enabled = false;
                    socket.isServer = false;
                    socket2.isServer = false;
                    panelCaroBoard.Enabled = false;
                    //labelYourName.Text = CaroBoard.Player[1].Name;
                    pictureYourMark.BackgroundImage = CaroBoard.Player[1].Mark;
                    Notification.fNotiMessage fn = new Notification.fNotiMessage();
                    fn.ShowDialog();
                    socket.Send(new SocketMessage((int)SocketCommand.START, new Point(), ""));
                    Listen();
                    //socket.Send(new SocketMessage((int)SocketCommand.CONNECT, new Point(), ""));
                    string m, s;
                    m = (timeRemainM / 60).ToString();
                    if (timeRemainM / 60 < 10) m = "0" + m;
                    s = (timeRemainM % 60).ToString();
                    if (timeRemainM % 60 < 10) s = "0" + s;
                    timeM.Text = "Time: " + m + ":" + s;

                    m = (timeRemainY / 60).ToString();
                    if (timeRemainY / 60 < 10) m = "0" + m;
                    s = (timeRemainY % 60).ToString();
                    if (timeRemainY % 60 < 10) s = "0" + s;
                    timeO.Text = "Time: " + m + ":" + s;

                }
                catch
                {
                    Notification.fNotiMessage f = new Notification.fNotiMessage();
                    Image img = DoAn.Properties.Resources.warning_removebg_preview;
                    f.setfNotiMessage(img, "Unable to connect", "Opponents are not on the same network");
                    f.TopMost = true;
                    f.ShowDialog();
                }
            }
            else if (isServer)
            {
                //Tiếp tục xử lý như trước
                checkConnect2Soc = false;
                socket2.IP = ipServer;
                socket.IP = "127.0.0.1";
                socket.isServer = true;
                socket2.isServer = true;
                panelCaroBoard.Enabled = false;
                butStart.Enabled = true;
                //labelYourName.Text = CaroBoard.Player[0].Name;

                cmd = "select lastname, userimage from UserInfor where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.CommandText = cmd;
                reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    labelMyName.Text = reader.GetString(0);
                    byte[] imgBytes = (byte[])reader["userimage"];
                    if (imgBytes != null && imgBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureMe.Image = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
                labelMyUsername.Text = "User: " + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;
                pictureMyMark.Image = CaroBoard.Player[0].Mark;
                pictureYourMark.Image = CaroBoard.Player[1].Mark;

                Image img = global::DoAn.Properties.Resources.Spin_1s_200px_unscreen;
                usNoti1.setusNoti(img, "Waiting for an opponent");
                usNoti1.setVisible(false);
                panelNoti.Visible = true;
                pictureYourMark.BackgroundImage = CaroBoard.Player[0].Mark;
                socket.setPort(30001);
                socket.CreateServer();
                socket2.setPort(30000);
                socket2.CreateServer();
                tmConnect.Start();
                string m, s;
                m = (timeRemainM / 60).ToString();
                if (timeRemainM / 60 < 10) m = "0" + m;
                s = (timeRemainM % 60).ToString();
                if (timeRemainM % 60 < 10) s = "0" + s;
                timeM.Text = "Time: " + m + ":" + s;

                m = (timeRemainY / 60).ToString();
                if (timeRemainY / 60 < 10) m = "0" + m;
                s = (timeRemainY % 60).ToString();
                if (timeRemainY % 60 < 10) s = "0" + s;
                timeO.Text = "Time: " + m + ":" + s;
            }

            /*            socket.IP = "127.0.0.1";
                        if (!socket.ConnectServer())
                        {
                            socket.isServer = true;
                            panelCaroBoard.Enabled = false;
                            butStart.Enabled = true;
                            labelYourName.Text = CaroBoard.Player[0].Name;
                            pictureYourMark.BackgroundImage = CaroBoard.Player[0].Mark;
                            socket.CreateServer();
                            MessageBox.Show("Nhấn PLAY đến khi tìm được đối thủ", "Hướng dẫn");
                        }
                        else
                        {
                            socket.isServer = false;
                            panelCaroBoard.Enabled = false;
                            labelYourName.Text = CaroBoard.Player[1].Name;
                            pictureYourMark.BackgroundImage = CaroBoard.Player[1].Mark;
                            MessageBox.Show("Đã kết nối", "Thông báo");
                            socket.Send(new SocketMessage((int)SocketCommand.START, new Point(), "Đã tìm thấy đối thủ"));
                            Listen();
                        }*/

        }

        private void CaroBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            panelCaroBoard.Enabled = false; //sau khi đánh xong sẽ bị vô hiệu hóa bàn cờ
            timerMe.Stop();
            changeTimeYou = true;
            //timerYou.Start();
            timerYou.Enabled = true;
            panelM.BorderColor = Color.Black;
            panelO.BorderColor = Color.Red;
            if (socket2.checkIsConnect())
                socket2.Send(new SocketMessage((int)SocketCommand.SEND_POINT, e.ClickedPoint, ""));
            else
                socket.Send(new SocketMessage((int)SocketCommand.SEND_POINT, e.ClickedPoint, ""));
            Listen();
        }

        private void CaroBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }
        int check = 0;
        void EndGame()
        {
            check = CaroBoard.CurrentPlayer;
            Image imagewin = DoAn.Properties.Resources.BS0r_unscreen , imagelose = DoAn.Properties.Resources.gg_unscreen;
            if (panelCaroBoard.Enabled == false )
            {
                usNoti1.setusNoti(imagewin, "YOU WIN");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.CommandText = "update Chart set win = win +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.ExecuteNonQuery();
            }
            if (panelCaroBoard.Enabled == true )
            {
                usNoti1.setusNoti(imagelose, "YOU LOSE");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.CommandText = "update Chart set lose = lose +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.ExecuteNonQuery();
            }
            CaroBoard.ChangePlayer();
            timerMe.Enabled = false;
            timerMe.Stop();
            timerYou.Enabled = false;
            panelCaroBoard.Enabled = false; //khóa bàn cờ
            usNoti1.setVisible(true);
            panelNoti.Visible = true;
            panelChat.Visible = false;
            panelNoti.BringToFront();
            isStart = false;

        }
        void dEndGame()
        {
            check = CaroBoard.CurrentPlayer;
            Image imagewin = DoAn.Properties.Resources.BS0r_unscreen, imagelose = DoAn.Properties.Resources.gg_unscreen;
            if (panelCaroBoard.Enabled == true)
            {
                usNoti1.setusNoti(imagewin, "YOU WIN");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.CommandText = "update Chart set win = win +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.ExecuteNonQuery();
            }
            if (panelCaroBoard.Enabled == false)
            {
                usNoti1.setusNoti(imagelose, "YOU LOSE");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.CommandText = "update Chart set lose = lose +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.ExecuteNonQuery();
            }
            timerMe.Enabled = false;
            timerMe.Stop();
            timerYou.Enabled = false;
            panelCaroBoard.Enabled = false; //khóa bàn cờ
            usNoti1.setVisible(true);
            panelNoti.Visible = true;
            panelChat.Visible = false;
            panelNoti.BringToFront();
            isStart = false;
        }

        void NewGame()
        {
            timeRemainM = tG;
            timeRemainY = tG;
            CaroBoard.drawBoard(); // reset bàn cờ
                                   //panelNoti.Visible = false;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.CommandText = "update Chart set numgame = numgame +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            sqlCmd.ExecuteNonQuery();
            isStart = true;
        }

        void ExitGame()
        {
            //Application.Exit();
            this.Close();
        }

        private void fCaro_Load(object sender, EventArgs e)
        {
            usWaiting1.Visible = true;
            usMenu1.Visible = false;
            worker.RunWorkerAsync();
        }

        private void fCaro_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (isServer && onHost)
                    socket.Send(new SocketMessage((int)SocketCommand.QUIT, new Point(), "")); // quit sẽ gửi thông báo cho phía kia
                else if (isServer && ! onHost)
                    socket2.Send(new SocketMessage((int)SocketCommand.QUIT, new Point(), ""));
                else
                    socket.Send(new SocketMessage((int)SocketCommand.QUIT, new Point(), "")); 
            }
            catch { }
            socket?.CloseConnect();
            socket2?.CloseConnect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string cmd = "delete from Room where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            sqlCmd.CommandText = cmd;
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();


        }

        private void fCaro_Shown(object sender, EventArgs e)
        {

        }

        public void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketMessage data;
                    if (socket2.checkIsConnect())
                        data = (SocketMessage)socket2.Receive();
                    else
                        data = (SocketMessage)socket.Receive();
                    ProcessData(data);
                }
                catch
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();

        }

        public void ProcessData(SocketMessage data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        /*                        timeRemainM = tG;
                                                timeRemainY = tG;*/

                        NewGame();
                        panelChat.Visible = false;
                        panelCaroBoard.Enabled = false;
                        panelM.BorderColor = Color.Black;
                        panelO.BorderColor = Color.Red;
                        panelNoti.Visible = false;
                        Image i = pictureMyMark.Image;
                        pictureMyMark.Image = pictureYourMark.Image;
                        pictureYourMark.Image = i;
                    }));

                    if (!socket.isServer)
                    {
                        CaroBoard.CurrentPlayer = 1;
                        CaroBoard.ChangePlayer();
                    }
                    break;
                case (int)SocketCommand.RQ_NEW_GAME:
                    Notification.fNotiMessageOKCancel fnO = new fNotiMessageOKCancel();
                    Image img = DoAn.Properties.Resources.notiIcon_removebg_preview;
                    fnO.setfNotiMessage(img, "The opponent wants", " to play a new game");
                    //fn.ShowDialog();
                    //DialogResult result = await ShowCustomFormAsync(fn);
                    DialogResult result = fnO.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        if (socket2.checkIsConnect())
                            socket2.Send(new SocketMessage((int)SocketCommand.REFUSE, new Point(), ""));
                        else
                            socket.Send(new SocketMessage((int)SocketCommand.REFUSE, new Point(), ""));
                    } 
                        
                    else
                    {
                        if (socket2.checkIsConnect())
                            socket2.Send(new SocketMessage((int)SocketCommand.NEW_GAME, new Point(), ""));
                        else
                            socket.Send(new SocketMessage((int)SocketCommand.NEW_GAME, new Point(), ""));
                        this.Invoke((MethodInvoker)(() =>
                        {
/*                            timeRemainM = tG;
                            timeRemainY = tG;*/
                            NewGame();
                            panelChat.Visible = false;
                            panelCaroBoard.Enabled = true;
                            panelM.BorderColor = Color.Red;
                            panelO.BorderColor = Color.Black;
                            //panelCaroBoard.Enabled = false;
                        }));
                        Image i = pictureMyMark.Image;
                        pictureMyMark.Image = pictureYourMark.Image;
                        pictureYourMark.Image = i;
/*                        if (socket.isServer)
                        {
                            CaroBoard.CurrentPlayer = 1;
                            //CaroBoard.ChangePlayer();
                        }*/
                    }
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>   //thay đổi giao diện
                    {
                        panelCaroBoard.Enabled = true;
                        CaroBoard.OtherPlayerMark(data.Point);
                        timerYou.Stop();
                        panelO.BorderColor = Color.Black;
                        timerMe.Start();
                        panelM.BorderColor = Color.Red;
                    }));
                    break;
                case (int)SocketCommand.QUIT:
                    img = DoAn.Properties.Resources.Amazing_removebg_preview;
                    Notification.fNotiMessage fn = new Notification.fNotiMessage();
                    fn.setfNotiMessage(img, "The opponent has escaped", "");
                    fn.ShowDialog();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        panelCaroBoard.Enabled = false;
                    }));
                    if (socket.isServer)
                    {
                        socket.CloseConnect();
                    }
                    break;
                case (int)SocketCommand.RESET:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        usNoti1.setVisible(true);
                        if (panelCaroBoard.Enabled != false)
                            dEndGame();
                        else
                            EndGame();
                        panelCaroBoard.Enabled = false;
                    }));
                    if (socket.isServer)
                    {
                        socket.CloseConnect();
                    }
                    break;
                case (int)SocketCommand.START:
                    panelNoti.Visible = false;
                    panelCaroBoard.Enabled = true;
                    break;
                case (int)SocketCommand.CONNECT:
                    panelNoti.Visible = false;
                    butStart.Visible = true;
                    break;
                case (int)SocketCommand.ENDGAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        usNoti1.setVisible(true);
                    }));
                    break;
                case (int)SocketCommand.REFUSE:
                    img = DoAn.Properties.Resources.sorry;
                    fn = new DoAn.Notification.fNotiMessage();
                    fn.setfNotiMessage(img, "Sorry", "The opponent refused");
                    fn.ShowDialog();
                    break;
                case (int)SocketCommand.RUNTIME:
                    timerYou.Enabled = true;
                    changeTimeYou = true;
                    panelO.BorderColor = Color.Red;
                    break;
                case (int)SocketCommand.SENDFILE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        setRecieveFile(data.DataSize, data.Data, data.Messege);
                    }));
                break;
                case (int)SocketCommand.SENDMESSAGE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        setRecieveMessage(data.Messege);
                    }));
                    break;
                default:
                    break;
            }
            Listen();
        }
        bool changeTimeYou = false;
        private void butStart_Click(object sender, EventArgs e)
        {
            isStart = true;
            butStart.Visible = false;
            timerMe.Start();
            panelM.BorderColor = Color.Red;
            Listen();
            if (socket2.checkIsConnect())
                socket2.Send(new SocketMessage((int)SocketCommand.RUNTIME, new Point(), ""));
            else
                socket.Send(new SocketMessage((int)SocketCommand.RUNTIME, new Point(), ""));

/*            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Chart set numgame = numgame + 1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();*/
        }
        bool click = true;
        private void butHideInfor_Click(object sender, EventArgs e)
        {
            if (click)
            {
                panelInfor.Visible = false;
                butHideInfor.ImageRotate = 180;
                click = false;
            }
            else
            {
                panelInfor.Visible = true;
                butHideInfor.ImageRotate = 0;
                click = true;
            }
        }

        private void fCaro_FormClosed(object sender, FormClosedEventArgs e)
        {
            socket.CloseConnect();
        }

        private void tmConnect_Tick(object sender, EventArgs e)
        {
            if (socket.isServer == false) tmConnect.Stop();
            if (socket.checkIsConnect() || socket2.checkIsConnect())
            {
                panelNoti.Visible = false;
                tmConnect.Stop();
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfMessage("Found an opponent", "Click \"Start game\" to start");
                fn.ShowDialog();
                butStart.Visible = true;
                usNoti1.setVisible(true);

                SqlCommand sqlCmd = new SqlCommand();
                string cmd = "select username2 from Room where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = cmd;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                string user2 = "";
                if(reader.Read())
                {
                    user2 = reader.GetString(0);
                }    
                reader.Close();

                cmd = "select lastname, userimage from UserInfor where username ='" + user2 + "'";
                sqlCmd.CommandText = cmd;
                reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    labelYourName.Text = reader.GetString(0);
                    labelChatUser.Text = labelYourName.Text;
                    byte[] imgBytes = (byte[])reader["userimage"];
                    if (imgBytes != null && imgBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureYour.Image = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
                labelYourUsername.Text = "User: " + user2;
                //Listen();
            }    
        }
        
        int timeRemainM, timeRemainY;

        private void timerYou_Tick(object sender, EventArgs e)
        {
            if (timeRemainY == 0)
            {
                timerYou.Stop();
                timerYou.Enabled = false;
                //socket.Send(new SocketMessage((int)SocketCommand.ENDGAME, new Point(), ""));
                dEndGame();
            }
            if (changeTimeYou)
            {

                string m, s;
                m = (timeRemainY / 60).ToString();
                if (timeRemainY / 60 < 10) m = "0" + m;
                s = (timeRemainY % 60).ToString();
                if (timeRemainY % 60 < 10) s = "0" + s;
                panelO.BorderColor = Color.Red;
                timeO.Text = "Time: " + m + ":" + s;
                timeRemainY--;
            }    
        }

        private void timerMe_Tick(object sender, EventArgs e)
        {
            if (timeRemainM == 0)
            {
                timerMe.Stop();
                timerMe.Enabled = false;
                //socket.Send(new SocketMessage((int)SocketCommand.ENDGAME, new Point(), ""));
                dEndGame();
            }
            string m, s;
            m = (timeRemainM / 60).ToString();
            if (timeRemainM / 60 < 10) m = "0" + m;
            s = (timeRemainM % 60).ToString();
            if (timeRemainM % 60 < 10) s = "0" + s;
            panelM.BorderColor = Color.Red;
            timeM.Text = "Time: " + m + ":" + s;
            timeRemainM--;  
        }

        public void getNewGame()
        {
            socket.Send(new SocketMessage((int)SocketCommand.RQ_NEW_GAME, new Point(), ""));
            usMenu1.Visible = false;
            usNoti1.Visible = true;
            panelNoti.Visible = false;
        }
        public void getExitGame()
        {
            ExitGame();
            usMenu1.Visible = false;
            panelNoti.Visible = false;
            ((fHome)Application.OpenForms["fHome"]).tabGame.PerformClick();
        }
        public void getSurrender()
        {
            if (socket2.checkIsConnect())
                socket2.Send(new SocketMessage((int)SocketCommand.RESET, new Point(), ""));
            else
                socket.Send(new SocketMessage((int)SocketCommand.RESET, new Point(), ""));

            usMenu1.Visible = false;
            usNoti1.Visible = true;
            if (panelCaroBoard.Enabled == false)
                dEndGame();
            else
                EndGame();
        }

        private void butSetting_Click(object sender, EventArgs e)
        {
            panelNoti.Visible = true;
            panelNoti.BringToFront();
            usNoti1.Visible = false;
            usMenu1.Visible = true;
        }
        public void butBackNoti()
        {
            usNoti1.Visible = true;
            usMenu1.Visible = false;
            panelNoti.Visible = false;
        }
        void setRecieveMessage(string s)
        {
            Chat.usYourMessage c = new Chat.usYourMessage();
            c.setLabelMessage(s);
            c.setPicture(pictureYour.Image);
            panelContentChat.Controls.Add(c);
            c.BringToFront();
            c.Dock = DockStyle.Top;
            ScrollToBottom();
        }
        void setRecieveFile(byte[] ds, byte[] d, string s)
        {
            Chat.usMyFile c = new Chat.usMyFile();
            c.setData(ds, d, s,pictureYour.Image);
            c.setPictureChinhMinh(pictureYour.Image);
            c.setDoithu();
            panelContentChat.Controls.Add(c);
            c.BringToFront();
            c.Dock = DockStyle.Top;
            ScrollToBottom();
        }
        private void ScrollToBottom()
        {
            panelContentChat.AutoScrollPosition = new Point(0, panelContentChat.VerticalScroll.Maximum);
        }
        private void butSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "") return;
            try
            {
                string mess = txtMessage.Text;
                Chat.usMyMessage c = new Chat.usMyMessage();
                c.setLabelMessage(mess);
                c.setPicture(pictureMe.Image);
                panelContentChat.Controls.Add(c);
                c.BringToFront();
                c.Dock = DockStyle.Top;
                ScrollToBottom();
                txtMessage.Text = "";
                txtMessage.Select();
                txtMessage.Multiline = false;
                txtMessage.Multiline = true;
                txtMessage.Clear();
                if (socket2.checkIsConnect())
                    socket2.Send(new SocketMessage((int)SocketCommand.SENDMESSAGE, new Point(), mess));
                else
                    socket.Send(new SocketMessage((int)SocketCommand.SENDMESSAGE, new Point(), mess));
                Listen();
            }catch
            {
                Notification.fNotiMessage fn = new fNotiMessage();
                Image img = DoAn.Properties.Resources.warning_removebg_preview;
                fn.setfNotiMessage(img, "No connected", "");
                fn.ShowDialog();
            }
            panelContentChat.VerticalScroll.Value = panelContentChat.VerticalScroll.Maximum;
            panelContentChat.ScrollControlIntoView(panelContentChat.Controls[panelContentChat.Controls.Count - 1]);

        }

        private void butBackFromChat_Click(object sender, EventArgs e)
        {
            panelChat.Visible = false;
        }

        private void butChat_Click(object sender, EventArgs e)
        {
            panelChat.Visible=true;
            panelChat.BringToFront();
            txtMessage.Select();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                int selectionStart = txtMessage.SelectionStart;
                string text = txtMessage.Text;
                txtMessage.Text = text.Insert(selectionStart, Environment.NewLine);
                txtMessage.SelectionStart = selectionStart + Environment.NewLine.Length;

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                butSend.PerformClick();
            }
        }
        private void butFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title =  "File need to send";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string fileExtension = Path.GetExtension(filePath);
                byte[] fileData = File.ReadAllBytes(filePath);
                byte[] fileSizeBytes = BitConverter.GetBytes(fileData.Length);
                if (socket2.checkIsConnect())
                    socket2.Send(new SocketMessage((int)SocketCommand.SENDFILE, fileSizeBytes,fileData,fileExtension));
                else
                    socket.Send(new SocketMessage((int)SocketCommand.SENDFILE,fileSizeBytes,fileData,fileExtension));
                Listen();
                Chat.usMyFile c = new Chat.usMyFile();
                c.setData(fileSizeBytes, fileData,fileExtension,pictureMe.Image);
                c.setPictureChinhMinh(pictureMe.Image);
                c.setChinhminh();
                panelContentChat.Controls.Add(c);
                c.BringToFront();
                c.Dock = DockStyle.Top;
                ScrollToBottom();

            }

        }

        public void bringMenuFront()
        {
            
        }
    }
}
