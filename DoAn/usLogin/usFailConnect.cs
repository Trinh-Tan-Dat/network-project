using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DoAn.usLogin
{
    public partial class usFailConnect : UserControl
    {
        public usFailConnect()
        {
            InitializeComponent();
        }

        private void butTryAgain_Click(object sender, EventArgs e)
        {
            waiting1.BringToFront();
            Task.Run(() =>
            {
                try
                {
                    if (((fLogin)Application.OpenForms["fLogin"]).sql == null)
                    {
                        ((fLogin)Application.OpenForms["fLogin"]).sql = new SqlConnection(((fLogin)Application.OpenForms["fLogin"]).strConnection);
                    }
                    if (((fLogin)Application.OpenForms["fLogin"]).sql.State == ConnectionState.Closed)
                    {
                        ((fLogin)Application.OpenForms["fLogin"]).sql.Open();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }).ContinueWith(task =>
            {
                if (task.Result)
                {
                    ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();
                }
                waiting1.SendToBack();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
    }
}
