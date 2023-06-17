using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Mail.MIME;
using Org.BouncyCastle.Bcpg;

namespace DoAn.Chat
{
    public partial class usMyFile : UserControl
    {
        public usMyFile()
        {
            InitializeComponent();
        }
        public void setDoithu()
        {
            panelMessage.Visible = false;
            pictureAvar.Visible = false;
            pictureAvar2.Visible = true;
            panelFile.Visible = true;
        }
        public void setChinhminh()
        {
            panelMessage.Visible = true;
            pictureAvar.Visible = true;
            pictureAvar2.Visible = false;
            panelFile.Visible = false;
        }
        public void setPictureChinhMinh(Image img)
        {
            pictureAvar.Image = img;
        }
        public void setPictureDoiThu(Image img)
        {
            pictureAvar2.Image = img;
        }
        byte[] dataSize;
        byte[] data;
        public void setData(byte[] ds, byte[] d, string file, Image img)
        {
            this.data = d;
            this.dataSize = ds;
            fileExtension = file;
            pictureAvar.Image = img;
            pictureAvar2.Image = img;
        }

        string fileExtension;
        private void panelMessage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Location save";
            sfd.Filter = "Files (*" + fileExtension + ")|*" + fileExtension + ".|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string savePath = sfd.FileName;
                if (data != null && dataSize != null)
                {
                    try
                    {
                        File.WriteAllBytes(savePath, data);
                    }
                    catch (Exception ex)
                    {
                    }
                }

            }   
                
        }
    }
}
