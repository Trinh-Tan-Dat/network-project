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
using System.Xml.Linq;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class fHome : Form
    {
        BackgroundWorker worker;
        public fHome()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }
        public string userChart;
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            usWaiting1.Visible = false;
            labelName.Text = fullname;
            labelPosition.Text = posi;
            OpenChildForm(ftabHome);
        }
        string fullname, posi;
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select u.firstname, u.lastname, a.typeacc, u.userimage from Account a join UserInfor u on a.username = u.username where a.username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm.Trim() + "'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string fname = "", lname = "", pos = "";
            if (reader.Read())
            {
                fname = reader.GetString(0);
                lname = reader.GetString(1);
                pos = reader.GetString(2);
                byte[] imgBytes = (byte[])reader["userimage"];
                if (imgBytes != null && imgBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        butAvarta.Image = Image.FromStream(ms);
                    }
                }
            }
            reader.Close();
            // labelName.Text = fname + " " + lname;
            fullname = fname + " " + lname;
            posi = pos;
            //labelPosition.Text = pos;
            typeacc = pos;
            if (typeacc != "Admin") userChart = ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm.Trim();
        }

        public bool loadFormChild = false;
        public Form currentFormChild;
        TabHome.fTabHome ftabHome = new TabHome.fTabHome();
        TabHome.fTabChangeInfor fTabChangeInfor = new TabHome.fTabChangeInfor();
        public TabHome.fTabAdmin fTabAdmin = new TabHome.fTabAdmin();
        public TabHome.fTabChart ftabChart = new TabHome.fTabChart();
        public TabHome.fTabGameRoom fTabGame = new TabHome.fTabGameRoom();
        public TabHome.fTabDoAn fDA = new TabHome.fTabDoAn();
        public void CloseChildForm()
        {
            currentFormChild.Close();
        }    
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild == null)
            {
                currentFormChild = childForm;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                panelus.Controls.Add(childForm);
                panelus.Tag = childForm;
                childForm.Show();
            }
            else if (currentFormChild != childForm)
            {
                try
                {
                    currentFormChild.Hide();
                    currentFormChild = childForm;
                    childForm.TopLevel = false;
                    childForm.Dock = DockStyle.Fill;
                    panelus.Controls.Add(childForm);
                    panelus.Tag = childForm;
                    childForm.Show();
                }
                catch
                {

                }
            }
            childForm.BringToFront();
        }



        private void moveImageBox(object sender)
        {
            imgSlide.Visible = true;
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {

            moveImageBox(sender);

        }
        public void formClose()
        {
            this.Close();
        }
        private void fHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
/*            if (loadFormChild)
                CloseChildForm();
            loadFormChild = false;*/
            Notification.Logout lo = new Notification.Logout();
            lo.Show();
        }
        ImageSQL im = new ImageSQL();
        public string typeacc;
        private void fHome_Load(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            loadFormChild = false;
            OpenChildForm(fTabChangeInfor);
            tabChat.Checked = false;
            tabHome.Checked = false;
            tabGame.Checked = false;
            tabChart.Checked = false;
            imgSlide.Visible = false;
        }

        public void tabGame_Click(object sender, EventArgs e)
        {
            if (loadFormChild)
                CloseChildForm();
            if (fTabGame != null)
            {
                fTabGame.Close();
            }    
            loadFormChild = true;
            fTabGame = new TabHome.fTabGameRoom();
            OpenChildForm(fTabGame);
        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            if (loadFormChild)
                CloseChildForm();
            loadFormChild = false;
            OpenChildForm(ftabHome);
        }

        private void tabChart_Click(object sender, EventArgs e)
        {
            if (loadFormChild)
                CloseChildForm();
            ftabChart = new TabHome.fTabChart();
            if (typeacc == "Admin")
            {
                fTabAdmin = new TabHome.fTabAdmin();
                OpenChildForm(fTabAdmin);
            }
            else
            {
                OpenChildForm(ftabChart);
            } 
                
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void tabChat_Click(object sender, EventArgs e)
        {
            if (loadFormChild)
                CloseChildForm();
            if (fDA != null)
            {
                fDA.Close();
            }
            loadFormChild = true;
            fDA = new TabHome.fTabDoAn();
            OpenChildForm(fDA);
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Active set isonline = 'false' where  username =  '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm.Trim() + "'; " + "delete from Room where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();
        }
    }
}
