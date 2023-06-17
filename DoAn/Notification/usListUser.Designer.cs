namespace DoAn.Notification
{
    partial class usListUser
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
            this.panelEach = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSTT = new System.Windows.Forms.Label();
            this.pictureInfor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.butDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelEach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEach
            // 
            this.panelEach.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelEach.BorderRadius = 20;
            this.panelEach.Controls.Add(this.labelEmail);
            this.panelEach.Controls.Add(this.labelGender);
            this.panelEach.Controls.Add(this.labelSTT);
            this.panelEach.Controls.Add(this.pictureInfor);
            this.panelEach.Controls.Add(this.labelName);
            this.panelEach.Controls.Add(this.butDelete);
            this.panelEach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEach.FillColor = System.Drawing.Color.Gray;
            this.panelEach.FillColor2 = System.Drawing.Color.Gray;
            this.panelEach.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.panelEach.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.panelEach.Location = new System.Drawing.Point(3, 3);
            this.panelEach.MaximumSize = new System.Drawing.Size(1054, 55);
            this.panelEach.MinimumSize = new System.Drawing.Size(1054, 55);
            this.panelEach.Name = "panelEach";
            this.panelEach.Size = new System.Drawing.Size(1054, 55);
            this.panelEach.TabIndex = 36;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(641, 17);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(219, 23);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "21520683@gmail.com";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(511, 19);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(54, 21);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "Male";
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.BackColor = System.Drawing.Color.Transparent;
            this.labelSTT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSTT.Location = new System.Drawing.Point(30, 19);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(21, 23);
            this.labelSTT.TabIndex = 23;
            this.labelSTT.Text = "1";
            // 
            // pictureInfor
            // 
            this.pictureInfor.BackColor = System.Drawing.Color.Transparent;
            this.pictureInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfor.Image = global::DoAn.Properties.Resources.icons8_user_male_64;
            this.pictureInfor.ImageRotate = 0F;
            this.pictureInfor.Location = new System.Drawing.Point(81, 3);
            this.pictureInfor.Name = "pictureInfor";
            this.pictureInfor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureInfor.Size = new System.Drawing.Size(54, 46);
            this.pictureInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfor.TabIndex = 0;
            this.pictureInfor.TabStop = false;
            this.pictureInfor.Click += new System.EventHandler(this.pictureInfor_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(141, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(350, 37);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nguyễn Thành Đăng";
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Transparent;
            this.butDelete.BorderRadius = 15;
            this.butDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butDelete.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.White;
            this.butDelete.Location = new System.Drawing.Point(966, 10);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 32);
            this.butDelete.TabIndex = 22;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // usListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEach);
            this.Name = "usListUser";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1069, 58);
            this.Load += new System.EventHandler(this.usListUser_Load);
            this.panelEach.ResumeLayout(false);
            this.panelEach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEach;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureInfor;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2GradientButton butDelete;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Label labelEmail;
    }
}
