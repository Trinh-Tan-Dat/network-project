using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.TabHome
{
    public partial class fTabAdmin : Form
    {
        private BackgroundWorker worker;

        public fTabAdmin()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void fTabAdmin_Load(object sender, EventArgs e)
        {
            usWaiting1.Visible = true;
            try
            {

                worker.RunWorkerAsync();
            }
            catch { }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<classUser> list = new List<classUser>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select u.username, firstname, lastname, email, gender, userimage, isonline from UserInfor u join Active a on u.username = a.username";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            try
            {
                SqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {
                    classUser user = new classUser();
                    user.username = read.GetString(0);
                    user.name = read.GetString(1) + " " + read.GetString(2);
                    user.email = read.GetString(3);
                    user.gender = read.GetString(4);
                    user.img = (byte[])read["userimage"];
                    user.online = read.GetBoolean(6);
                    list.Add(user);
                }
                read.Close();
                int stt = list.Count;
                for (int i = 0; i < stt - 1; i++)
                {
                    for (int j = i + 1; j < stt; j++)
                    {
                        if (list[i].online && !list[j].online)
                        {
                            classUser temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
                try
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        Notification.usListUser us = new Notification.usListUser();
                        list[i].stt = stt--;
                        //list[i].stt = i + 1;
                        us.setClass(list[i]);
                        panelMain.Invoke(new MethodInvoker(delegate () {
                            panelMain.Controls.Add(us);
                            //us.BringToFront();
                            us.Dock = DockStyle.Top;
                        }));
                    }
                }
                catch { }
            }
            catch {
                return;
            }

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            usWaiting1.Visible = false;
            isTaskRunning = false;
        }
        public string user;
        private bool isTaskRunning = false;

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (!isTaskRunning)
            {
                panelMain.Controls.Clear();
                usWaiting1.Visible = true;
                isTaskRunning = true;
                worker.RunWorkerAsync();
            }
        }

        public void refresh()
        {
            butRefresh.PerformClick();
        }    
    }
}
