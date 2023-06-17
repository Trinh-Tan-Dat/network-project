using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace DoAn.TabHome
{
    public partial class fTabChangeInfor : Form
    {
        public fTabChangeInfor()
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

        public void setButCode()
        {
            butCode.Text = "Code";
        }
        public void setTxtCode()
        {
            textCode.Enabled = false;
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //((fHome)Application.OpenForms["fHome"]).usChangeInfor1.SendToBack();
            this.SendToBack();
        }
        int countdownValue = 30;
        private void butCode_Click(object sender, EventArgs e)
        {
            butCode.Enabled = false;
            textCode.Enabled = true;
            textCode.Select();
            countdownValue = 30;
            timer1.Start();
            butCode.Text = countdownValue.ToString();

            otp.sendOTP(defaultEmail);
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
        string gender = null;
        OTP otp = new OTP();
        int otpCode;
        bool Conti = true;
        private void butSave_Click(object sender, EventArgs e)
        {
            Conti = true;
            labelCode.Text = "Please input code";
            labelCode.Visible = false;
            labelPassword.Visible = false;
            labelNewpass.Visible = false;
            labelConPass.Text = "Please input password";
            labelConPass.Visible = false;
            labelPassword.Text = "Please input password";
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
                lbfemale.ForeColor = Color.Red;
                lbMale.ForeColor = Color.Red;
                lbOther.ForeColor = Color.Red;
                return;
            }

            if (textCode.Text == "")
            {
                textCode.FocusedState.BorderColor = Color.Red;
                textCode.Select();
                labelCode.Visible = true;
                return;
            }


            if (!(otpCode.ToString().Trim().Equals(textCode.Text.Trim())))
            {
                textCode.FocusedState.BorderColor = Color.Red;
                textCode.Select();
                labelCode.Visible = true;
                labelCode.Text = "Wrong OTP";
                return;
            }

            if (textPassword.Text != "" || textConpass.Text != "" || textNewpass.Text != "")
            {
                if (textPassword.Text == "" && (textConpass.Text != "" || textNewpass.Text != ""))
                {
                    textPassword.FocusedState.BorderColor = Color.Red;
                    textPassword.Select();
                    labelPassword.Visible = true;
                    return;

                }
                if (textPassword.Text != "" && textConpass.Text == "" && textNewpass.Text == "")
                {
                    textNewpass.FocusedState.BorderColor = Color.Red;
                    textNewpass.Select();
                    labelNewpass.Visible = true;
                    return;
                }
                if (textPassword.Text != "" && textConpass.Text == "" && textNewpass.Text != "")
                {
                    textConpass.FocusedState.BorderColor = Color.Red;
                    textConpass.Select();
                    labelConPass.Visible = true;
                    return;

                }
                if (textPassword.Text != "" && textConpass.Text != "" && textNewpass.Text == "")
                {
                    textNewpass.FocusedState.BorderColor = Color.Red;
                    textNewpass.Select();
                    labelNewpass.Visible = true;
                    return;
                }
                if (textPassword.Text != "" && textConpass.Text != "" && textNewpass.Text != "")
                {
                    if (textNewpass.Text != textConpass.Text)
                    {
                        textConpass.FocusedState.BorderColor = Color.Red;
                        textConpass.Select();
                        labelConPass.Visible = true;
                        labelConPass.Text = "Passwords are not the same";
                        return;
                    }
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select pass from account where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "' ";
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                string checkpass = "";
                if (reader.Read())
                {
                    checkpass = reader.GetString(0);
                }
                reader.Close();
                if (checkpass != HashPassword(textPassword.Text))
                {
                    textPassword.FocusedState.BorderColor = Color.Red;
                    textPassword.Select();
                    labelPassword.Visible = true;
                    labelPassword.Text = "Wrong password";
                    return;
                }
            }



            if (defaultEmail != textEmail.Text)
            {
                Conti = false;
                try
                {
                    panelConfirmNewEmail.Visible = true;
                    otp.sendOTP(textEmail.Text);
                    otpCode = otp.codeOTP;
                    butCode.Visible = false;
                    butSave.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            if (Conti)
            {
                string cmdNonPass = "update UserInfor set firstname = @first , lastname = @last, email = @em, gender = @gen where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                string cmdFull = "update UserInfor set firstname = @first , lastname = @last, email = @em, gender = @gen where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "' ; update Account set pass = @pas where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                string cmd;
                if (textPassword.Text == "")
                {
                    cmd = cmdNonPass;
                }
                else cmd = cmdFull;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = cmd;
                SqlParameter first = new SqlParameter("@first", SqlDbType.NVarChar);
                SqlParameter last = new SqlParameter("@last", SqlDbType.NVarChar);
                SqlParameter em = new SqlParameter("@em", SqlDbType.VarChar);
                SqlParameter gen = new SqlParameter("@gen", SqlDbType.NVarChar);
                SqlParameter pass = new SqlParameter("@pas", SqlDbType.VarChar);
                last.Value = textLastname.Text;
                first.Value = textFirstname.Text;
                em.Value = textEmail.Text;
                gen.Value = gender;
                pass.Value = HashPassword(textNewpass.Text.Trim());
                sqlCmd.Parameters.Add(last);
                sqlCmd.Parameters.Add(first);
                sqlCmd.Parameters.Add(em);
                sqlCmd.Parameters.Add(pass);
                sqlCmd.Parameters.Add(gen);
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.ExecuteNonQuery();
                textCode.Text = "";
                textCode.Enabled = false;
                labelLoginAgain.Visible = true;
                defaultEmail = textEmail.Text;
                countdownValue = 1; //Tắt chạy ngầm tránh ảnh hưởng log out
            }
        }
        string defaultEmail;
        

        private void textFirstname_TextChanged(object sender, EventArgs e)
        {
            if (textFirstname.Text != null)
            {
                labelFirstname.Visible = false;
                textFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void textLastname_TextChanged(object sender, EventArgs e)
        {
            if (textLastname.Text != null)
            {
                labelLastname.Visible = false;
                textLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            if (textEmail.Text != null)
            {
                labelEmail.Visible = false;
                textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }


        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text != null)
            {
                labelPassword.Visible = false;
                textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
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
                lbfemale.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
                lbMale.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
                lbOther.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
                labelGender.Visible = false;
            }
        }

        private void textNewpass_TextChanged(object sender, EventArgs e)
        {
            if (textNewpass.Text != null)
            {
                labelNewpass.Visible = false;
                textNewpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void textConpass_TextChanged(object sender, EventArgs e)
        {
            if (textConpass.Text != null)
            {
                labelConPass.Visible = false;
                textConpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {
            if (textCode.Text != null)
            {
                labelCode.Visible = false;
                textCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void butConfirmNewEmail_Click(object sender, EventArgs e)
        {
            if (labelNewEmail.Text == "")
            {
                textCodeNewEmail.FocusedState.BorderColor = Color.Red;
                textCodeNewEmail.Select();
                labelNewEmail.Visible = true;
                labelNewEmail.Text = "Please input otp";
                return;
            }
            if (!(otpCode.ToString().Trim().Equals(textCodeNewEmail.Text.Trim())))
            {
                textCodeNewEmail.FocusedState.BorderColor = Color.Red;
                textCodeNewEmail.Select();
                labelNewEmail.Visible = true;
                labelNewEmail.Text = "Wrong OTP";

                return;
            }
            textCodeNewEmail.Text = "";
            butCancel.PerformClick();
            string cmdNonPass = "update UserInfor set firstname = @first , lastname = @last, email = @em, gender = @gen where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            string cmdFull = "update UserInfor set firstname = @first , lastname = @last, email = @em, gender = @gen where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "' ; update Account set pass = @pas where username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
            string cmd;
            if (textPassword.Text == "")
            {
                cmd = cmdNonPass;
            }
            else cmd = cmdFull;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = cmd;
            SqlParameter first = new SqlParameter("@first", SqlDbType.NVarChar);
            SqlParameter last = new SqlParameter("@last", SqlDbType.NVarChar);
            SqlParameter em = new SqlParameter("@em", SqlDbType.VarChar);
            SqlParameter gen = new SqlParameter("@gen", SqlDbType.NVarChar);
            SqlParameter pass = new SqlParameter("@pas", SqlDbType.VarChar);
            last.Value = textLastname.Text;
            first.Value = textFirstname.Text;
            em.Value = textEmail.Text;
            gen.Value = gender;
            pass.Value = textNewpass.Text;
            sqlCmd.Parameters.Add(last);
            sqlCmd.Parameters.Add(first);
            sqlCmd.Parameters.Add(em);
            sqlCmd.Parameters.Add(pass);
            sqlCmd.Parameters.Add(gen);
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();
            textCode.Text = "";
            labelLoginAgain.Visible = true;
            defaultEmail = textEmail.Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            panelConfirmNewEmail.Visible = false;
            labelNewpass.Visible = false;
            textCodeNewEmail.Text = "";
            butCode.Visible = true;
            butSave.Visible = true;
        }

        private void textCodeNewEmail_TextChanged(object sender, EventArgs e)
        {
            if (textCodeNewEmail.Text != null)
            {
                labelNewEmail.Visible = false;
                textCodeNewEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdownValue--;
            butCodeNewEmail.Text = countdownValue.ToString();
            if (countdownValue == 0)
            {
                timer2.Stop();
                butCodeNewEmail.Enabled = true;
                butCodeNewEmail.Text = "Send again";
                countdownValue = 30;
            }
        }

        private void butCodeNewEmail_Click(object sender, EventArgs e)
        {
            butCodeNewEmail.Enabled = false;
            textCodeNewEmail.Enabled = true;
            countdownValue = 30;
            timer2.Start();
            butCodeNewEmail.Text = countdownValue.ToString();
        }
        ImageSQL im = new ImageSQL();
        private void butChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureInfor.Image = Image.FromFile(ofd.FileName);
                byte[] m = im.PathToStream(ofd.FileName);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                string cmd = "update UserInfor set userimage = @sim where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.CommandText = cmd;
                SqlParameter sim = new SqlParameter("@sim", m);
                sqlCmd.Parameters.Add(sim);
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.ExecuteNonQuery();
            }
        }
        private void fTabChangeInfor_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            string type = "";
            try
            {
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select u.firstname, u.lastname, u.email, u.gender, a.typeacc, u.userimage from UserInfor u join Account a on u.username = a.username where u.username = '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    textFirstname.Text = reader.GetString(0);
                    textLastname.Text = reader.GetString(1);
                    textEmail.Text = reader.GetString(2);
                    gender = reader.GetString(3);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (gender == "Male") radioMale.Checked = true;
            else if (gender == "Female") radioFemale.Checked = true;
            else radioOther.Checked = true;
            labelSetName.Text = textFirstname.Text + " " + textLastname.Text;
            labelSetEmail.Text = "Email: " + textEmail.Text;
            labelSetGender.Text = "Gender: " + gender;
            labelSetPosition.Text = "Position: " + type;
            labelUsername.Text = ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;





            defaultEmail = textEmail.Text;
        }

        private void butChangeImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureInfor.Image = Image.FromFile(ofd.FileName);
                byte[] m = im.PathToStream(ofd.FileName);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                string cmd = "update UserInfor set userimage = @sim where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "'";
                sqlCmd.CommandText = cmd;
                SqlParameter sim = new SqlParameter("@sim", m);
                sqlCmd.Parameters.Add(sim);
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
