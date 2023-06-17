using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.TabHome;

namespace DoAn.Notification
{
    public partial class fCreate : Form
    {
        public fCreate()
        {
            InitializeComponent();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }


        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string time = null;
        string typeGame = null;
        public string GetLocalIPv4()
        {
            string wirelessIPAddress = null;

            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up);

            foreach (var networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    var properties = networkInterface.GetIPProperties();

                    var addresses = properties.UnicastAddresses
                        .Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork);

                    foreach (var address in addresses)
                    {
                        wirelessIPAddress = address.Address.ToString();
                        break;
                    }
                    if (!string.IsNullOrEmpty(wirelessIPAddress))
                    {
                        break;
                    }
                }
            }

            return wirelessIPAddress;
        }
        private void butCreate_Click(object sender, EventArgs e)
        {
            if (typeGame == null)
            {
                labelWarnGame.Visible = true;
                return;
            }
            if (time == null)
            {
                labelWarnTime.Visible = true;
                radio5min.ForeColor = Color.Red;
                radio10min.ForeColor = Color.Red;
                radio15min.ForeColor = Color.Red;
                return;
            }

            string ipadd = GetLocalIPv4();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            string cmd = "insert into Room (username, ipadd, timeplay, typegame, isbusy) values('" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm + "',@ipadd,@time,@type,'false')";
            sqlCmd.CommandText = cmd;
            SqlParameter ip = new SqlParameter("@ipadd", SqlDbType.VarChar);
            SqlParameter timeplay = new SqlParameter("@time", SqlDbType.Int);
            SqlParameter type = new SqlParameter("@type", SqlDbType.Int);
            if (typeGame == "Caro") type.Value = 0;
            else type.Value = 1;
            //Cần thay đổi chô này nếu muốn thêm nhiều game
            timeplay.Value = Int32.Parse(time);
            ip.Value = ipadd;

            sqlCmd.Parameters.Add(timeplay);
            sqlCmd.Parameters.Add(ip);
            sqlCmd.Parameters.Add(type);
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();

            if (((fHome)Application.OpenForms["fHome"]).fTabGame.fcr != null)
            {
                ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.Close();
            }
            ((fHome)Application.OpenForms["fHome"]).currentFormChild.Close();
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr = new Caro.fCaro();

            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.isServer = true;
            ((fHome)Application.OpenForms["fHome"]).fTabGame.user = ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm;

            ((fHome)Application.OpenForms["fHome"]).OpenChildForm(((fHome)Application.OpenForms["fHome"]).fTabGame.fcr);
            this.Close();

        }

        private void radio5min_CheckedChanged(object sender, EventArgs e)
        {
            if (radio5min.Checked)
            {
                time = "5";
            }    
            else if (radio10min.Checked)
            {
                time = "10";
            }    
            else
            {
                time = "15";
            }
            if (radio5min.Checked || radio10min.Checked ||  radio15min.Checked)
            {
                radio5min.ForeColor = Color.Black;
                radio10min.ForeColor = Color.Black;
                radio15min.ForeColor = Color.Black;
                labelWarnTime.Visible = false;
            }
        }

        private void radioChess_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCaro.Checked)
            {
                typeGame = "Caro";
            }
            else
            {
                typeGame = "Chess";
            } 
            if (radioCaro.Checked )
            {
                labelWarnGame.Visible = false;
            }    
        }
    }
}
