using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Notification;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DoAn.TabHome
{
    public partial class fTabGameRoom : Form
    {
        public BackgroundWorker worker;

        public fTabGameRoom()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }
        public Caro.fCaro fcr;
        public string user;
        public int minGame;
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<classRoomGame> list = new List<classRoomGame>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string cmd = "select u.username, typegame, ipadd, isbusy, timeplay from UserInfor u join Room r on r.username = u.username";
            sqlCmd.CommandText = cmd;
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            try
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while(reader.Read())
                {
                    classRoomGame c = new classRoomGame();
                    c.username = reader.GetString(0);
                    user = c.username;
                    c.typegame = reader.GetInt32(1);
                    c.IP = reader.GetString(2);
                    c.online = reader.GetBoolean(3);
                    c.min = reader.GetInt32(4);
                    minGame = c.min;
                    list.Add(c);
                }
                reader.Close();
                for (int i = 0; i < list.Count; i++) 
                {
                    if (i %2 ==0)
                    {
                        Notification.usListRoom us = new Notification.usListRoom();
                        us.setClass(list[i]);
                        panelMainLeft.Invoke(new MethodInvoker(delegate () {
                            panelMainLeft.Controls.Add(us);
                            us.Dock = DockStyle.Top;
                        }));

                    }
                    else
                    {
                        Notification.usListRoom us = new Notification.usListRoom();
                        us.setClass(list[i]);
                        panelMainRight.Invoke(new MethodInvoker(delegate () {
                            panelMainRight.Controls.Add(us);
                            us.Dock = DockStyle.Top;
                        }));
                    }
                }

            }catch
            {

            }
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            usWaiting1.Visible = false;
        }

        private void fTabGameRoom_Load(object sender, EventArgs e)
        {
            usWaiting1.Visible = true;
            worker.RunWorkerAsync();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                panelMainLeft.Controls.Clear();
                panelMainRight.Controls.Clear();
                usWaiting1.Visible = true;
                worker.RunWorkerAsync();
            }
            catch { } 
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            Notification.fCreate fc = new Notification.fCreate();
            fc.ShowDialog();
        }

        private void fTabGameRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fcr != null)
            {
                fcr.Close();
            }    
            fcr = null;
        }
    }
}
