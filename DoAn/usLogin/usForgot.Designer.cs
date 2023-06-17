namespace DoAn.usLogin
{
    partial class usForgot
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butContinue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butBackFor = new Guna.UI2.WinForms.Guna2Button();
            this.textUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.usNewPass1 = new DoAn.usLogin.usNewPass();
            this.usCodeChange1 = new DoAn.usLogin.usCodeChange();
            this.panelCheck = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNotiAgain = new System.Windows.Forms.Label();
            this.butDiffOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelNotiDiff = new System.Windows.Forms.Label();
            this.panelCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 21;
            this.label3.Tag = "";
            this.label3.Text = "Username";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Red;
            this.labelUser.Location = new System.Drawing.Point(12, 132);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(137, 17);
            this.labelUser.TabIndex = 39;
            this.labelUser.Tag = "";
            this.labelUser.Text = "Please input username";
            this.labelUser.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(14, 222);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(111, 17);
            this.labelEmail.TabIndex = 45;
            this.labelEmail.Tag = "";
            this.labelEmail.Text = "Please input email";
            this.labelEmail.Visible = false;
            // 
            // textEmail
            // 
            this.textEmail.BorderRadius = 15;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.IconLeftSize = new System.Drawing.Size(0, 0);
            this.textEmail.IconRightSize = new System.Drawing.Size(25, 25);
            this.textEmail.Location = new System.Drawing.Point(15, 180);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.PlaceholderText = "Abc@gmail.com";
            this.textEmail.SelectedText = "";
            this.textEmail.Size = new System.Drawing.Size(300, 38);
            this.textEmail.TabIndex = 44;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            this.textEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEmail_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 43;
            this.label4.Tag = "";
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "FORGOT PASSWORD";
            // 
            // butContinue
            // 
            this.butContinue.BorderRadius = 15;
            this.butContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butContinue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butContinue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butContinue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butContinue.ForeColor = System.Drawing.Color.White;
            this.butContinue.Location = new System.Drawing.Point(48, 266);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(229, 45);
            this.butContinue.TabIndex = 47;
            this.butContinue.Text = "Continue";
            this.butContinue.Click += new System.EventHandler(this.butContinue_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butBackFor
            // 
            this.butBackFor.BorderRadius = 4;
            this.butBackFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBackFor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butBackFor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butBackFor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butBackFor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butBackFor.FillColor = System.Drawing.Color.Transparent;
            this.butBackFor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butBackFor.ForeColor = System.Drawing.Color.White;
            this.butBackFor.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butBackFor.Image = global::DoAn.Properties.Resources.backIcon;
            this.butBackFor.Location = new System.Drawing.Point(-13, 0);
            this.butBackFor.Name = "butBackFor";
            this.butBackFor.Size = new System.Drawing.Size(59, 39);
            this.butBackFor.TabIndex = 50;
            this.butBackFor.Click += new System.EventHandler(this.butBackFor_Click);
            // 
            // textUser
            // 
            this.textUser.BorderRadius = 15;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.DefaultText = "";
            this.textUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.textUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUser.IconLeftSize = new System.Drawing.Size(0, 0);
            this.textUser.IconRightSize = new System.Drawing.Size(25, 25);
            this.textUser.Location = new System.Drawing.Point(13, 90);
            this.textUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.PlaceholderText = "Username";
            this.textUser.SelectedText = "";
            this.textUser.Size = new System.Drawing.Size(300, 38);
            this.textUser.TabIndex = 20;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            this.textUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyDown);
            // 
            // usNewPass1
            // 
            this.usNewPass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usNewPass1.Location = new System.Drawing.Point(0, 0);
            this.usNewPass1.Name = "usNewPass1";
            this.usNewPass1.Size = new System.Drawing.Size(347, 536);
            this.usNewPass1.TabIndex = 52;
            this.usNewPass1.Visible = false;
            // 
            // usCodeChange1
            // 
            this.usCodeChange1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usCodeChange1.Location = new System.Drawing.Point(0, 0);
            this.usCodeChange1.Name = "usCodeChange1";
            this.usCodeChange1.Size = new System.Drawing.Size(347, 536);
            this.usCodeChange1.TabIndex = 51;
            this.usCodeChange1.Visible = false;
            // 
            // panelCheck
            // 
            this.panelCheck.Controls.Add(this.labelNotiAgain);
            this.panelCheck.Controls.Add(this.butDiffOk);
            this.panelCheck.Controls.Add(this.labelNotiDiff);
            this.panelCheck.Location = new System.Drawing.Point(5, 61);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(339, 338);
            this.panelCheck.TabIndex = 53;
            this.panelCheck.Visible = false;
            // 
            // labelNotiAgain
            // 
            this.labelNotiAgain.AutoSize = true;
            this.labelNotiAgain.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotiAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.labelNotiAgain.Location = new System.Drawing.Point(20, 107);
            this.labelNotiAgain.Name = "labelNotiAgain";
            this.labelNotiAgain.Size = new System.Drawing.Size(285, 25);
            this.labelNotiAgain.TabIndex = 38;
            this.labelNotiAgain.Tag = "";
            this.labelNotiAgain.Text = "Please check the password and email";
            // 
            // butDiffOk
            // 
            this.butDiffOk.BorderRadius = 15;
            this.butDiffOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDiffOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDiffOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDiffOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDiffOk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDiffOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDiffOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butDiffOk.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butDiffOk.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiffOk.ForeColor = System.Drawing.Color.White;
            this.butDiffOk.Location = new System.Drawing.Point(81, 154);
            this.butDiffOk.Name = "butDiffOk";
            this.butDiffOk.Size = new System.Drawing.Size(159, 45);
            this.butDiffOk.TabIndex = 37;
            this.butDiffOk.Text = "OK";
            this.butDiffOk.Click += new System.EventHandler(this.butDiffOk_Click);
            // 
            // labelNotiDiff
            // 
            this.labelNotiDiff.AutoSize = true;
            this.labelNotiDiff.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotiDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.labelNotiDiff.Location = new System.Drawing.Point(19, 71);
            this.labelNotiDiff.Name = "labelNotiDiff";
            this.labelNotiDiff.Size = new System.Drawing.Size(317, 36);
            this.labelNotiDiff.TabIndex = 36;
            this.labelNotiDiff.Tag = "";
            this.labelNotiDiff.Text = "Password or email not correct";
            // 
            // usForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.butBackFor);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.usNewPass1);
            this.Controls.Add(this.usCodeChange1);
            this.Name = "usForgot";
            this.Size = new System.Drawing.Size(347, 536);
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox textUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelEmail;
        public Guna.UI2.WinForms.Guna2TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton butContinue;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button butBackFor;
        public usCodeChange usCodeChange1;
        public usNewPass usNewPass1;
        private Guna.UI2.WinForms.Guna2Panel panelCheck;
        private System.Windows.Forms.Label labelNotiAgain;
        private Guna.UI2.WinForms.Guna2GradientButton butDiffOk;
        private System.Windows.Forms.Label labelNotiDiff;
    }
}
