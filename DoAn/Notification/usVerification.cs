using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace DoAn.Notification
{
    public partial class usVerification : UserControl
    {
        public usVerification()
        {
            InitializeComponent();
        }
        public static string HashPassword(string password)
        {
            // Chuyển đổi mật khẩu thành mảng byte
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Tạo đối tượng SHA256
            SHA256 sha256 = SHA256.Create();

            // Tính toán giá trị băm
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            // Chuyển đổi giá trị băm thành chuỗi hexa
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            return hashString;
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void clear()
        {
            textCode.Text = "";
        }






        OTP otp = new OTP();
        int otpCode;
        public int count = 0;
        int countdownValue = 30;
        private void butCode_Click(object sender, EventArgs e)
        {
            count++;
            butCode.Enabled = false;
            countdownValue = 30;
            timer1.Start();
            butCode.Text = countdownValue.ToString();

            //Gửi mã xác nhận
            otp.sendOTP(((fLogin)Application.OpenForms["fLogin"]).usRegister1.textEmail.Text);
            otpCode = otp.codeOTP;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownValue--;
            butCode.Text = countdownValue.ToString();
            if (countdownValue == 0)
            {
                timer1.Stop();
                butCode.Enabled = true;
                butCode.Text = "Send again";
                countdownValue = 30;
            }
        }
        public void selectTxtCode()
        {
            textCode.Select();
        }    
        private void butCreate_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usRegister1.butBack.PerformClick();
        }

        ImageSQL ssql = new ImageSQL();
        private void butLogin_Click(object sender, EventArgs e)
        {
            labelCode.Text = "Please input code";
            if (count == 0)
            {
                otpCode = ((fLogin)Application.OpenForms["fLogin"]).usRegister1.otpCode;
            }
            if (otpCode.ToString().Trim().Equals(textCode.Text.Trim()))
            {
                string gender;
                var x = ((fLogin)Application.OpenForms["fLogin"]).usRegister1;
                if (x.radioFemale.Checked) gender = "Female";
                else if (x.radioMale.Checked) gender = "Male";
                else gender = "#N/A";
                try
                { 
                    byte[] im = null;
                    if (gender == "Female")
                    {
                        im = ssql.ImageToStream(DoAn.Properties.Resources.icons8_female_user_64);
                    }
                    else if (gender == "Male")
                    {
                        im = ssql.ImageToStream(DoAn.Properties.Resources.icons8_user_male_64);
                    }
                    else
                        im = ssql.ImageToStream(DoAn.Properties.Resources.icons8_heart_rainbow_48);


                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    string cmd = "INSERT INTO Account(username, pass, typeacc) VALUES ('" + x.textUser.Text + "','" + HashPassword(x.textPassword.Text.Trim()) + "','Player')";
                    sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                    sqlCmd.CommandText = cmd;
                    sqlCmd.ExecuteNonQuery();

                    SqlParameter sim = new SqlParameter("@sim", SqlDbType.Image);
                    sim.Value = im;
                    sqlCmd.Parameters.Add(sim);

                    cmd = "INSERT INTO UserInfor (firstname, lastname, email, gender, username, userimage) VALUES ('" + x.textFirstname.Text + "','" + x.textLastname.Text + "','" + x.textEmail.Text + "','" + gender + "','" + x.textUser.Text + "', @sim);";
                    sqlCmd.CommandText = cmd;
                    sqlCmd.ExecuteNonQuery();


                    labelNoti2.Text = "You can login now";
                    labelNoti.Text = "Sign up success";
                    panelNoti.Visible = true;
                    
                }
                catch (Exception ex)
                {
                    labelNoti.Text = "Already exists account";
                    labelNoti2.Text = "Username or email already exists";
                    panelNoti.Visible = true;
                }

            }
            else
            {
                textCode.FocusedState.BorderColor = Color.Red;
                textCode.Select();
                labelCode.Text = "Wrong OTP";
                labelCode.Visible = true;
                return;
            }
        }

        private void usVerification_Load(object sender, EventArgs e)
        {
            
        }

        private void butOKSuccess_Click(object sender, EventArgs e)
        {
            panelNoti.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();
        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {
            if (textCode.Text != null)
            {
                labelCode.Visible = false;
                textCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }


        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butLogin.PerformClick();
            }
        }
    }
}
