using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.DoAn13
{
    public partial class usMessMail : UserControl
    {
        public usMessMail()
        {
            InitializeComponent();
        }
        private InforMail i;
        public void setMail(string sub, string body)
        {
            lbSub.Text = sub;
            lbBody.Text = body;
        }
        public void set(InforMail i)
        {
            this.i = i;
        }    
        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            ((fMail)Application.OpenForms["fMail"]).panelSend.Visible = false;
            ((fMail)Application.OpenForms["fMail"]).panelReadMail.Visible = true;
            ((fMail)Application.OpenForms["fMail"]).ShowMail(i.subject,i.from,i.body,i.subject);


        }

    }
}
