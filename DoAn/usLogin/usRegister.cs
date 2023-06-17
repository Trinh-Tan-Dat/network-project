using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.usLogin
{
    public partial class usRegister : UserControl
    {
        public usRegister()
        {
            InitializeComponent();
        }
        string gender = null;
        public void  clearGender()
        {
            gender = null;
        }    
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }

            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
            if (checkPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        public void butBack_Click(object sender, EventArgs e)
        {
/*            if (textFirstname.Text != "" || textLastname.Text != "" || textEmail.Text != "" || textUser.Text != "" || textPassword.Text != "") 
            {
                Notification.backLogin bl = new Notification.backLogin();
                bl.Show();
            }
            else*/
              ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();


        }
        public void clear()
        {
            textFirstname.Text = "";
            textLastname.Text = "";
            textEmail.Text = "";
            textUser.Text = "";
            textPassword.Text = "";
        }    
        private void usRegister_Load(object sender, EventArgs e)
        {
        }
        public int otpCode ;
        OTP otp = new OTP();
        private void butLogin_Click(object sender, EventArgs e)
        {
            this.usVerification1.count = 0;
            if (textFirstname.Text == "")
            {
                textFirstname.FocusedState.BorderColor = Color.Red;
                textFirstname.Select();
                labelFirstname.Visible = true;
                return;
            }
            if (textLastname.Text == "")
            {
                textLastname.FocusedState.BorderColor = Color.Red;
                textLastname.Select();
                labelLastname.Visible = true;
                return;
            }
            if (textEmail.Text == "")
            {
                textEmail.FocusedState.BorderColor = Color.Red;
                textEmail.Select();
                labelEmail.Visible = true;
                return;
            }
            if (gender == null)
            {
                labelGender.Visible = true;
                radioFemale.ForeColor = Color.Red;
                radioMale.ForeColor = Color.Red;
                radioOther.ForeColor = Color.Red;
                return;
            } 
            if (textUser.Text == "")
            {
                textUser.FocusedState.BorderColor = Color.Red;
                textUser.Select();
                labelUser.Visible = true;
                return;
            }
            if (textPassword.Text == "")
            {
                textPassword.FocusedState.BorderColor = Color.Red;
                textPassword.Select();
                labelPassword.Visible = true;
                return;
            }
            //Notification.usVerification ver = new Notification.usVerification();
            usVerification1.Visible = true;
            usVerification1.selectTxtCode();
            usVerification1.clear();
            otp.sendOTP(textEmail.Text);
            otpCode = otp.codeOTP;

            //Lưu account vào Sql


        }

        private void textFirstname_TextChanged(object sender, EventArgs e)
        {
            if (textFirstname.Text != null)
            {
                labelFirstname.Visible = false;
                textFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void textLastname_TextChanged(object sender, EventArgs e)
        {
            if (textLastname.Text != null)
            {
                labelLastname.Visible = false;
                textLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
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

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text != null)
            {
                labelPassword.Visible = false;
                textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOther.Checked)
            {
                gender = "#N/A";            
            }    
            if (radioMale.Checked)
            {
                gender = "Male";
            }    
            if (radioFemale.Checked)
            {
                gender = "Female";
            }    
            if (radioOther.Checked || radioMale.Checked || radioFemale.Checked)
            {
                radioFemale.ForeColor = System.Drawing.Color.FromArgb(84, 111, 150);
                radioMale.ForeColor = System.Drawing.Color.FromArgb(84, 111, 150);
                radioOther.ForeColor = System.Drawing.Color.FromArgb(84, 111, 150);
                labelGender.Visible = false;
            }
        }

        private void textPassword_Load(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }

        private void usVerification1_Load(object sender, EventArgs e)
        {

        }
    }
}
