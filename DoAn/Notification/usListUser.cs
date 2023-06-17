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
using DoAn.TabHome;

namespace DoAn.Notification
{
    public partial class usListUser : UserControl
    {
        public usListUser()
        {
            InitializeComponent();
        }
        classUser c = new classUser();
        public void setClass(classUser cu)
        {
            c = cu;

        }
        public void setSTT(int a)
        {
            c.stt = a;
        }
        public string getUsername()
        {
            return c.username;
        }    
        private void usListUser_Load(object sender, EventArgs e)
        {
            if (c == null)
            {
                return;
            }
            if (c.online)
            {
                panelEach.FillColor = Color.Green;
                panelEach.FillColor2 = Color.Green;
                panelEach.FillColor3 = Color.FromArgb(203, 203, 227);
                panelEach.FillColor4 = Color.FromArgb(203, 203, 227);
                labelName.ForeColor = Color.Black;
                labelEmail.ForeColor = Color.Black;
                labelGender.ForeColor = Color.Black;

            }
            else
            {
                panelEach.FillColor = Color.Gray;
                panelEach.FillColor2 = Color.Gray;
                panelEach.FillColor3 = Color.FromArgb(203, 203, 227);
                panelEach.FillColor4 = Color.FromArgb(203, 203, 227);
                labelName.ForeColor = Color.FromArgb(64, 64, 64);
                labelEmail.ForeColor = Color.FromArgb(64, 64, 64);
                labelGender.ForeColor = Color.FromArgb(64, 64, 64);
            }
            if (c.username == ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm)
                butDelete.Visible = false;
            labelSTT.Text = c.stt.ToString();
            labelName.Text = c.name;
            labelGender.Text = c.gender;
            labelEmail.Text = c.email;
            MemoryStream ms = new MemoryStream(c.img);
            pictureInfor.Image = Image.FromStream(ms);
        }

        private void pictureInfor_Click(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).CloseChildForm();
            if (((fHome)Application.OpenForms["fHome"]).typeacc == "Admin")
                ((fHome)Application.OpenForms["fHome"]).userChart = c.username;
            else
            {
                ((fHome)Application.OpenForms["fHome"]).userChart = ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;
            } 
                
            ((fHome)Application.OpenForms["fHome"]).OpenChildForm(new TabHome.fTabChart());
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select typeacc from account where username='" + c.username + "'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string typeacc = "";
            if (reader.Read())
            {
                typeacc = reader.GetString(0);
            }  
            reader.Close();
            Notification.DeleteAdmin da = new Notification.DeleteAdmin();
            if (typeacc == "Admin")
            {
                da.setLabel("This is admin account");
            }
            else da.setLabel("You want to delete this account");
            ((fHome)Application.OpenForms["fHome"]).fTabAdmin.user = c.username;
            da.ShowDialog();
       
        }
    }
}
