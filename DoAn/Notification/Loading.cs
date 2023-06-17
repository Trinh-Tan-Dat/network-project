using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Notification
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            panelIn.Width = 0;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            while (panelIn.Width < panelOut.Width - 12)
            {
                panelIn.Width += 5;
                Application.DoEvents();
                Thread.Sleep(2);
            }

            Timer.Stop();
        }
        private void panelIn_Paint(object sender, PaintEventArgs e)
        {
            if (panelIn.Width >= panelOut.Width - 12) 
            {  
                ((fLogin)Application.OpenForms["fLogin"]).usLogin1.home = new fHome();
                ((fLogin)Application.OpenForms["fLogin"]).usLogin1.home.Show();
                this.Close();
            }    
        }
    }
}
