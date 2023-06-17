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
    public partial class usCodeChange : UserControl
    {
        public usCodeChange()
        {
            InitializeComponent();
        }

        int countdownValue = 30;
        OTP otp = new OTP();
        int otpCode;
        private void butCode_Click(object sender, EventArgs e)
        {
            butConfirm.Enabled = false;
            countdownValue = 30;
            timer1.Start();
            butConfirm.Text = countdownValue.ToString();

            //Gửi mã xác nhận
            otp.sendOTP(((fLogin)Application.OpenForms["fLogin"]).usForgot1.textEmail.Text);
            otpCode = otp.codeOTP;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownValue--;
            butConfirm.Text = countdownValue.ToString();
            if (countdownValue == 0)
            {
                timer1.Stop();
                butConfirm.Enabled = true;
                butConfirm.Text = "Send again";
                countdownValue = 30;
            }
        }
        public int count = 0;
        private void butConfirm_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                otpCode = ((fLogin)Application.OpenForms["fLogin"]).usForgot1.otpCode;
            }
            if (otpCode.ToString().Trim().Equals(textCode.Text.Trim()))
            {
                ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.Visible = true;
                ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usCodeChange1.Visible = false;
                ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.BringToFront();
            }
            else panelNoti.Visible = true;
        }

        private void butOKSuccess_Click(object sender, EventArgs e)
        {
            panelNoti.Visible = false;
        }
        public void clear()
        {
            textCode.Text = "";
        }
        private void butBack_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usCodeChange1.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.usNewPass1.panelchageSuccess.Visible = false;
            ((fLogin)Application.OpenForms["fLogin"]).usForgot1.BringToFront();
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butConfirm.PerformClick();
            }
        }
    }
}
