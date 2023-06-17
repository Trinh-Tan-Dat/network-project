using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Notification
{
    public partial class usNoti : UserControl
    {
        public usNoti()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.usMenu1.Visible = true;
            //((fHome)Application.OpenForms["fHome"]).fTabGame.fcr.panelNoti.Visible = false;
        }
        public void setusNoti(Image img, string m)
        {
            pictureGif.Image = img;
            labelMess.Text = m;
        }


        private void usNoti_Load(object sender, EventArgs e)
        {

        }
        public void setVisible(bool x)
        {
            butOK.Visible = x;
        }
    }
}
