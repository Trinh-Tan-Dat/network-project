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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace DoAn.usLogin
{
    public partial class usLogin : UserControl
    {
        public usLogin()
        {
            InitializeComponent();
        }
        public string userNameForm;
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
        }

        private void textPassword_Load(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }
        public void clear()
        {
            textPassword.Clear();
        }
        public fHome home = new fHome();
        public void clearShowPass()
        {
            checkPassword.Checked = false;
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.FocusedState.BorderColor = Color.Red;
                textUser.Select();
                labelUser.Text = "Please input username";
                labelUser.Visible = true;
                return;
            }
            if (textPassword.Text == "")
            {
                textPassword.FocusedState.BorderColor = Color.Red;
                textPassword.Select();
                labelPassword.Text = "Please input password";
                labelPassword.Visible = true;
                return;
            }
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = " select a.pass from Account a where a.username = @userN";
                SqlParameter user = new SqlParameter("@userN", SqlDbType.VarChar);
                user.Value = textUser.Text;
                sqlCmd.Parameters.Add(user);
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                string password = "";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    password = reader.GetString(0);
                }
                reader.Close();
                if (password == "")
                {
                    textUser.FocusedState.BorderColor = Color.Red;
                    textUser.Select();
                    labelUser.Text = "Username does not exist";
                    labelUser.Visible = true;
                    return;
                }    
                if (password.Trim() !=HashPassword( textPassword.Text.Trim()))
                {
                    textPassword.FocusedState.BorderColor = Color.Red;
                    textPassword.Select();
                    labelPassword.Text = "Wrong password";
                    labelPassword.Visible = true;
                    return;
                }
/*                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                sqlCmd.CommandText = "select isonline from Active where username = '" + textUser.Text + "'";
                reader = sqlCmd.ExecuteReader();
                bool onl = false;
                if (reader.Read())
                {
                    onl = reader.GetBoolean(0);
                }
                reader.Close();
                if (onl)
                {
                    Notification.fNotiMessage fn = new Notification.fNotiMessage();
                    Image img = DoAn.Properties.Resources.warning_removebg_preview;
                    fn.setfNotiMessage(img,"Can't login for some reason", "Someone is logging into your account");
                    fn.Show();
                    return;
                }
                else
                {*/
                    userNameForm = textUser.Text;
                    sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "update Active set isonline = 'true' where username =  '" + userNameForm + "'";
                    sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                    sqlCmd.ExecuteNonQuery();
                    Notification.Loading load = new Notification.Loading();
                    load.Show();
                    ((fLogin)Application.OpenForms["fLogin"]).Hide();

//                }


            }catch
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfMessage("Can't login for some reason", "Looks like someone is logging into your account");
                fn.Show();
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

        private void butCreate_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usRegister1.BringToFront();
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butLogin.PerformClick();
            }    
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.BringToFront();
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPassword.Select();
            }
        }
    }
}
