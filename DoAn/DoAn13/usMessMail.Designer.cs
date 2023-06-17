namespace DoAn.DoAn13
{
    partial class usMessMail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usMessMail));
            this.panelListMail = new Guna.UI2.WinForms.Guna2Panel();
            this.lbBody = new System.Windows.Forms.Label();
            this.lbSub = new System.Windows.Forms.Label();
            this.picUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelListMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListMail
            // 
            this.panelListMail.BorderColor = System.Drawing.Color.Black;
            this.panelListMail.BorderRadius = 10;
            this.panelListMail.BorderThickness = 2;
            this.panelListMail.Controls.Add(this.lbBody);
            this.panelListMail.Controls.Add(this.lbSub);
            this.panelListMail.Controls.Add(this.picUser);
            this.panelListMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListMail.FillColor = System.Drawing.Color.White;
            this.panelListMail.Location = new System.Drawing.Point(0, 0);
            this.panelListMail.Name = "panelListMail";
            this.panelListMail.Size = new System.Drawing.Size(338, 92);
            this.panelListMail.TabIndex = 3;
            this.panelListMail.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // lbBody
            // 
            this.lbBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBody.Location = new System.Drawing.Point(119, 33);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(191, 45);
            this.lbBody.TabIndex = 5;
            this.lbBody.Text = "label2";
            this.lbBody.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // lbSub
            // 
            this.lbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSub.ForeColor = System.Drawing.Color.Black;
            this.lbSub.Location = new System.Drawing.Point(119, 12);
            this.lbSub.Name = "lbSub";
            this.lbSub.Size = new System.Drawing.Size(191, 18);
            this.lbSub.TabIndex = 4;
            this.lbSub.Text = "SUBJECT";
            this.lbSub.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.ImageRotate = 0F;
            this.picUser.Location = new System.Drawing.Point(30, 12);
            this.picUser.Name = "picUser";
            this.picUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picUser.Size = new System.Drawing.Size(65, 62);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 3;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // usMessMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelListMail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(338, 0);
            this.Name = "usMessMail";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Size = new System.Drawing.Size(338, 97);
            this.Click += new System.EventHandler(this.guna2Panel1_Click);
            this.panelListMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelListMail;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Label lbSub;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picUser;
    }
}
