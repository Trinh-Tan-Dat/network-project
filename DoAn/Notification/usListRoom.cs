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
using Microsoft.VisualBasic.ApplicationServices;

namespace DoAn.Notification
{
    public partial class usListRoom : UserControl
    {
        public usListRoom()
        {
            InitializeComponent();
        } 
        classRoomGame c = new classRoomGame();
        public string getUsername()
        {
            return c.username;
        }    
        public void setClass(classRoomGame cr)
        {
            c = cr;
        }

        private void usListRoom_Load(object sender, EventArgs e)
        {
            if (c.typegame == 0)
            {
                labelNameGame.Text = "CARO";
                pictureGame.Image = DoAn.Properties.Resources.caro;
            }    
            else if (c.typegame == 1)
            {
                labelNameGame.Text = "CHESS";
                pictureGame.Image = DoAn.Properties.Resources.chinese_chess_2;
            }    
            if (!c.online)
            {
                butJoin.Visible = true;
                labelSatus.Text = "Status: Waiting";
            }    
            else
            {
                butJoin.Visible = false;
                labelSatus.Text = "Status: Playing";
            }
            labelUsername.Text = "Username: " + c.username;
            labelTime.Text = "Time: " + c.min.ToString() + " mins"; 
        }
        private void butJoin_Click(object sender, EventArgs e)
        {
            if (((fHome)Application.OpenForms["fHome"]).fTabGame.fcr != null)
            {
                ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.Close();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string cmd = "update Room set username2 = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "' where username = '" + c.username + "'";
            sqlCmd.CommandText = cmd;
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();
/*            sqlCmd.CommandText = "update Chart set numgame = numgame +1 where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            sqlCmd.ExecuteNonQuery();*/
            ((fHome)Application.OpenForms["fHome"]).currentFormChild.Close();
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr = new Caro.fCaro();

            ((fHome)Application.OpenForms["fHome"]).fTabGame.user = c.username;
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.isServer = false;
            ((fHome)Application.OpenForms["fHome"]).OpenChildForm(((fHome)Application.OpenForms["fHome"]).fTabGame.fcr);

        }
    }
}
