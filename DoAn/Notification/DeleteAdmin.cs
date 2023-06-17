using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Notification
{
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
        }
        public void setLabel(string s)
        {
            labelWarning.Text = s;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from Active where username='"  + ((fHome)Application.OpenForms["fHome"]).fTabAdmin.user + "'; delete from Chart where username='"  + ((fHome)Application.OpenForms["fHome"]).fTabAdmin.user + "'";
            sqlCmd.Connection = ((fLogin)Application.OpenForms["fLogin"]).sql;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "delete from UserInfor where username ='" + ((fHome)Application.OpenForms["fHome"]).fTabAdmin.user + "'"; 
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "delete from Account where username='" + ((fHome)Application.OpenForms["fHome"]).fTabAdmin.user + "'";
            sqlCmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            ((fHome)Application.OpenForms["fHome"]).fTabAdmin.refresh();
            this.Close();
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DeleteAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
