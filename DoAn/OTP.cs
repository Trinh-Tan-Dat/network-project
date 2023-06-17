using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using MimeKit;
namespace DoAn
{
    internal class OTP
    {
        public int codeOTP;
        Random random = new Random();
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
        public void sendOTP(string s )
        {
            try
            {
                codeOTP = random.Next(10000, 99999);
/*                var fromAddress = new MailAddress("project.q2dcrew@gmail.com");
                var toAddress = new MailAddress(s.ToString());
                const string frompass = "69b5ab1eb232270d0ed1dac59dcd8d90b75dd282fd1dcf3b1e207e86f8445033";
                const string subject = "OTP Code";
                string body ="Mã xác nhận của app Q2D \n" + codeOTP.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address,HashPassword(frompass)),
                    Timeout = 25000
                };
                using (var message = new MailMessage(fromAddress,toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    await smtp.SendMailAsync(message);
                }*/
                const string fromAddress = "project.q2dcrew@gmail.com";
                string toAddress = s.ToString();
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate("project.q2dcrew@gmail.com", "dedmtiamkhmqedsa"); // gmail account, app password
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", fromAddress));
                message.To.Add(new MailboxAddress("", toAddress));
                message.Subject = "OTP Code";
                message.Body = new TextPart("plain") // gửi ở dạng plain text, hoặc có thể thay
                {
                    Text = "Mã xác nhận của app Q2D \n" + codeOTP.ToString()
                };
                client.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
