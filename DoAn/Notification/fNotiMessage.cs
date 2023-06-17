using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Notification
{
    public partial class fNotiMessage : Form
    {
        public fNotiMessage()
        {
            InitializeComponent();
        }
        public DialogResult FormResult { get; private set; }
        public  void setfNotiMessage(Image img, string s1, string s2)
        {
            picture.BackgroundImage = img;
            label0.Text = s1;
            label1.Text = s2;
        }
        public void setfMessage( string s1, string s2)
        {
            label0.Text = s1;
            label1.Text = s2;
        }
        public fNotiMessage( string s1, string s2)
        {
            label0.Text = s1;
            label1.Text = s2;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            FormResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void butNo_Click(object sender, EventArgs e)
        {
            FormResult = DialogResult.Cancel;
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

    }
}
