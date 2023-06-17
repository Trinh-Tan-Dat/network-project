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
using static System.Net.WebRequestMethods;

namespace DoAn.usLogin
{
    public partial class usForgot : UserControl
    {
        public usForgot()
        {
            InitializeComponent();
        }

        OTP otp = new OTP();
        public int otpCode;

        private void butContinue_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.FocusedState.BorderColor = Color.Red;
                textUser.Select();
                labelUser.Visible = true;
                return;
            }
            if (textEmail.Text == "")
            {
                textEmail.FocusedState.BorderColor = Color.Red;
                textEmail.Select();
                labelEmail.Visible = true;
                return;
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = " select i.email from Account a join UserInfor i on a.username = i.username where a.username = @userN";
            SqlParameter user = new SqlParameter("@userN", SqlDbType.VarChar);
            user.Value = textUser.Text;
            string email="";
            sqlCmd.Parameters.Add(user);
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                email = reader.GetString(0);
            }
            reader.Close();
            if (email.Trim() != ((fLogin)Application.OpenForms["fLogin"]).usForgot1.textEmail.Text.Trim())
            {
                panelCheck.Visible=true;
                return;
            }    
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usCodeChange1.clear();
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.clear();
            otp.sendOTP(textEmail.Text);
            otpCode = otp.codeOTP;
            usCodeChange1.BringToFront();
            usCodeChange1.Visible = true;

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            if (textEmail.Text != null)
            {
                labelEmail.Visible = false;
                textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            if (textUser.Text != null)
            {
                labelUser.Visible = false;
                textUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void butBackFor_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();
        }

        private void textEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butContinue.PerformClick();
            }    
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butContinue.PerformClick();
            }
        }

        private void butDiffOk_Click(object sender, EventArgs e)
        {
            panelCheck.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
