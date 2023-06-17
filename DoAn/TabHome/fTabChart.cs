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
    public partial class fTabChart : Form
    {
        BackgroundWorker worker;
        public fTabChart()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        { 
            usWaiting1.Visible = false;
            labelSetName.Text = name;
            labelSetEmail.Text = email;
            labelSetGender.Text = gender;
            labelSetPosition.Text = pos;
            labelUsername.Text = ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;

            if (typegame == false)
            {
                lbNumGame.Text = "Number of match: " + num.ToString();
                if (num == 0)
                {
                    lbLose.Text = "Lose rate: 0%";
                    lbWin.Text = "Win rate: 0%";
                    ChartCaro.Value = 0;
                    lbChartCaro.Text = "0%";
                }    else
                {
                    lbLose.Text = "Lose rate: " + Math.Round((float)(lose*100) / num, 2).ToString() + "%";
                    lbWin.Text = " Win rate: " + Math.Round((float)(win*100) / num, 2).ToString() + "%";
                    ChartCaro.Value =(int) win / num;
                    lbChartCaro.Text = "Win: " + Math.Round((float) (win * 100) /num).ToString() + "%";

                }    

            }    
        }
        string name, email, gender, pos;
        int win, lose, num;
        bool typegame;
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            string type = "";
            string first ="", last ="";
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select u.firstname, u.lastname, u.email, u.gender, a.typeacc, u.userimage from UserInfor u join Account a on u.username = a.username where u.username = '" + ((fHome)Application.OpenForms["fHome"]).userChart + "'";
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    first = reader.GetString(0);
                    last = reader.GetString(1);
                    name = first + " " + last;
                    email ="Email: " + reader.GetString(2);
                    gender ="Gender: " + reader.GetString(3);
                    type = reader.GetString(4);
                    byte[] imgBytes = (byte[])reader["userimage"];
                    if (imgBytes != null && imgBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureInfor.Image = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
                sqlCmd.CommandText = "select c.win, c.lose, c.numgame, c.typegame from Chart c where username ='" + ((fHome)Application.OpenForms["fHome"]).userChart + "'";
                reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    win = reader.GetInt32(0);
                    lose = reader.GetInt32(1);
                    num = reader.GetInt32(2);
                    typegame = reader.GetBoolean(3);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            pos = "Position: " + type;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).CloseChildForm();
            ((fHome)Application.OpenForms["fHome"]).OpenChildForm(new TabHome.fTabAdmin());
            this.Close();
            this.Dispose();
/*            this.Hide();
            this.SendToBack();*/
        }

        private void fTabChart_Load(object sender, EventArgs e)
        {
            usWaiting1.Visible = true;
            if (((fHome)Application.OpenForms["fHome"]).typeacc =="Admin")
            {
                butBack.Visible = true;
            }    
            else
            {
                butBack.Visible = false;
            }
            worker.RunWorkerAsync();

        }
    }
}
