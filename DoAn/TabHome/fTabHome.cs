using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.TabHome
{
    public partial class fTabHome : Form
    {
        BackgroundWorker worker;
        public fTabHome()
        {
            worker = new BackgroundWorker();
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).usWaiting1.Visible = false;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select userimage from UserInfor where username = '21520683' or username = '21520421' or username = '21520714' order by username asc";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                byte[] imgBytes = (byte[])reader["userimage"];
                if (imgBytes != null && imgBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        pictureQuoc.Image = Image.FromStream(ms);
                    }
                }
                imgBytes = null;
                if (reader.Read())
                {
                    byte[] imgBytes2 = (byte[])reader["userimage"];
                    if (imgBytes2 != null && imgBytes2.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes2))
                        {
                            pictureDang.Image = Image.FromStream(ms);
                        }
                    }
                    imgBytes2 = null;
                    if (reader.Read())
                    {
                        byte[] imgBytes3 = (byte[])reader["userimage"];
                        if (imgBytes3 != null && imgBytes3.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imgBytes3))
                            {
                                pictureDat.Image = Image.FromStream(ms);
                            }
                        }
                        imgBytes3 = null;
                    }
                }
            }
            reader.Close();
        }

        private void fTabHome_Load(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).usWaiting1.Visible = true;
            try
            {
                worker.RunWorkerAsync();
            }
            catch
            {
                worker.Dispose();
            }
        }
    }
}
