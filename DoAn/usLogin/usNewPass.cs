using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.usLogin
{
    public partial class usNewPass : UserControl
    {
        public usNewPass()
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
        private void butChangePass_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.FocusedState.BorderColor = Color.Red;
                textPassword.Select();
                labelPassword.Visible = true;
                return;
            }
            if (textConPassword.Text == "")
            {
                textConPassword.FocusedState.BorderColor = Color.Red;
                textConPassword.Select();
                labelConPassword.Visible = true;
                return;
            }
            if (textConPassword.Text != textPassword.Text)
            {
                panelDifferent.Visible = true;
                return;
            }    
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                string textUser = ((fLogin)Application.OpenForms["fLogin"]).usForgot1.textUser.Text;
                sqlCmd.CommandType = CommandType.Text;
                string cmd = "Update Account set pass = '" + HashPassword(textConPassword.Text) + "' where username ='" + textUser + "'";
                sqlCmd.CommandText = cmd;
                sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
                int k = sqlCmd.ExecuteNonQuery();
                panelchageSuccess.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void clear()
        {
            textConPassword.Text = "";
            textPassword.Text = "";
        }

        private void butDiffOk_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.panelDifferent.Visible = false;
        }
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text != null)
            {
                labelPassword.Visible = false;
                textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void textConPassword_TextChanged(object sender, EventArgs e)
        {
            if (textConPassword.Text != null)
            {
                labelConPassword.Visible = false;
                textConPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void butBackNew_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usCodeChange1.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.panelchageSuccess.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.BringToFront();
        }

        private void butChangeSuccess_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.panelchageSuccess.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();
        }

        private void textConPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
