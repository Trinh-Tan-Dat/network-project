namespace DoAn
{
    partial class fLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.usLogin1 = new DoAn.usLogin.usLogin();
            this.usRegister1 = new DoAn.usLogin.usRegister();
            this.failConnect1 = new DoAn.usLogin.usFailConnect();
            this.usForgot1 = new DoAn.usLogin.usForgot();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(920, 37);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(843, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(39, 30);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(878, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(39, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // pictureLogin
            // 
            this.pictureLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureLogin.Image = global::DoAn.Properties.Resources.person_login;
            this.pictureLogin.ImageRotate = 0F;
            this.pictureLogin.Location = new System.Drawing.Point(0, 37);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(573, 543);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 2;
            this.pictureLogin.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 3000;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // usLogin1
            // 
            this.usLogin1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.usLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usLogin1.Location = new System.Drawing.Point(573, 37);
            this.usLogin1.Name = "usLogin1";
            this.usLogin1.Size = new System.Drawing.Size(347, 543);
            this.usLogin1.TabIndex = 3;
            this.usLogin1.Load += new System.EventHandler(this.usLogin1_Load);
            // 
            // usRegister1
            // 
            this.usRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usRegister1.Location = new System.Drawing.Point(0, 0);
            this.usRegister1.Name = "usRegister1";
            this.usRegister1.Size = new System.Drawing.Size(920, 580);
            this.usRegister1.TabIndex = 4;
            // 
            // failConnect1
            // 
            this.failConnect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.failConnect1.Location = new System.Drawing.Point(0, 0);
            this.failConnect1.Name = "failConnect1";
            this.failConnect1.Size = new System.Drawing.Size(920, 580);
            this.failConnect1.TabIndex = 5;
            // 
            // usForgot1
            // 
            this.usForgot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usForgot1.Location = new System.Drawing.Point(0, 0);
            this.usForgot1.Name = "usForgot1";
            this.usForgot1.Size = new System.Drawing.Size(920, 580);
            this.usForgot1.TabIndex = 6;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(923, 583);
            this.Controls.Add(this.usLogin1);
            this.Controls.Add(this.pictureLogin);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.usRegister1);
            this.Controls.Add(this.failConnect1);
            this.Controls.Add(this.usForgot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fLogin_FormClosed);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogin;
        public usLogin.usLogin usLogin1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        public usLogin.usRegister usRegister1;
        private usLogin.usFailConnect failConnect1;
        public usLogin.usForgot usForgot1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

