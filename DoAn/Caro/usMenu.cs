using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Caro
{
    public partial class usMenu : UserControl
    {
        public usMenu()
        {
            InitializeComponent();
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.getNewGame();
        }

        private void butSurrender_Click(object sender, EventArgs e)
        {
            if (((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.isStart)
            {
                ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.getSurrender();
            }
            else
            {
                Notification.fNotiMessage fn = new Notification.fNotiMessage();
                fn.setfNotiMessage(DoAn.Properties.Resources.warning_removebg_preview, "Haven't start", " Can't surrender");
                fn.ShowDialog();
            } 
                
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.getExitGame();
        }

        private void butBackNoti_Click(object sender, EventArgs e)
        {
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.butBackNoti();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butSound_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = false;
        }
    }
}
