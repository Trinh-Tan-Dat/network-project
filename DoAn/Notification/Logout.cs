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

namespace DoAn.Notification
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.clear();
            ((fLogin)Application.OpenForms["fLogin"]).usRegister1.clear();
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.home.Hide();
            ((fLogin)Application.OpenForms["fLogin"]).Show();

            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.clearShowPass();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Active set isonline ='false' where username =  '" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm.Trim() + "'; " + "delete from Room where username ='" + ((fLogin)Application.OpenForms["fLogin"]).usLogin1.userNameForm +"'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();

            if ( ((fHome)Application.OpenForms["fHome"]).loadFormChild)
                ((fHome)Application.OpenForms["fHome"]).CloseChildForm();
            ((fHome)Application.OpenForms["fHome"]).loadFormChild = false;
            this.Close();
           // fl.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
