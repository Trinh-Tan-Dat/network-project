namespace DoAn.Notification
{
    partial class usVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usVerification));
            this.textCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelCode = new System.Windows.Forms.Label();
            this.butCode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butUSback = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNoti = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNoti2 = new System.Windows.Forms.Label();
            this.butOKSuccess = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelNoti = new System.Windows.Forms.Label();
            this.butBack = new Guna.UI2.WinForms.Guna2Button();
            this.panelNoti.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCode
            // 
            this.textCode.BorderRadius = 10;
            this.textCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCode.DefaultText = "";
            this.textCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.textCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCode.IconLeftSize = new System.Drawing.Size(0, 0);
            this.textCode.IconRightSize = new System.Drawing.Size(25, 25);
            this.textCode.Location = new System.Drawing.Point(20, 158);
            this.textCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCode.Name = "textCode";
            this.textCode.PasswordChar = '\0';
            this.textCode.PlaceholderText = "";
            this.textCode.SelectedText = "";
            this.textCode.Size = new System.Drawing.Size(159, 36);
            this.textCode.TabIndex = 32;
            this.textCode.TextChanged += new System.EventHandler(this.textCode_TextChanged);
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.label7.Location = new System.Drawing.Point(15, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 31;
            this.label7.Tag = "";
            this.label7.Text = "Verification Code";
            // 
            // butLogin
            // 
            this.butLogin.BorderRadius = 15;
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(43, 238);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(229, 45);
            this.butLogin.TabIndex = 33;
            this.butLogin.Text = "OK";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.Color.Red;
            this.labelCode.Location = new System.Drawing.Point(17, 198);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(107, 17);
            this.labelCode.TabIndex = 34;
            this.labelCode.Tag = "";
            this.labelCode.Text = "Please input code";
            this.labelCode.Visible = false;
            // 
            // butCode
            // 
            this.butCode.BorderRadius = 15;
            this.butCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butCode.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butCode.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCode.ForeColor = System.Drawing.Color.White;
            this.butCode.Location = new System.Drawing.Point(194, 157);
            this.butCode.Name = "butCode";
            this.butCode.Size = new System.Drawing.Size(120, 37);
            this.butCode.TabIndex = 36;
            this.butCode.Text = "Send again";
            this.butCode.Click += new System.EventHandler(this.butCode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butUSback
            // 
            this.butUSback.BackColor = System.Drawing.Color.Transparent;
            this.butUSback.BorderRadius = 15;
            this.butUSback.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.butUSback.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.butUSback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butUSback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butUSback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butUSback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butUSback.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butUSback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butUSback.FillColor = System.Drawing.Color.Transparent;
            this.butUSback.FillColor2 = System.Drawing.Color.Transparent;
            this.butUSback.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUSback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.butUSback.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butUSback.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.butUSback.Location = new System.Drawing.Point(157, 429);
            this.butUSback.Name = "butUSback";
            this.butUSback.Size = new System.Drawing.Size(100, 80);
            this.butUSback.TabIndex = 38;
            this.butUSback.Text = "Login";
            this.butUSback.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(80, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 37;
            this.label3.Tag = "";
            this.label3.Text = "Back to ";
            // 
            // panelNoti
            // 
            this.panelNoti.Controls.Add(this.labelNoti2);
            this.panelNoti.Controls.Add(this.butOKSuccess);
            this.panelNoti.Controls.Add(this.labelNoti);
            this.panelNoti.Location = new System.Drawing.Point(20, 109);
            this.panelNoti.Name = "panelNoti";
            this.panelNoti.Size = new System.Drawing.Size(303, 194);
            this.panelNoti.TabIndex = 39;
            this.panelNoti.Visible = false;
            // 
            // labelNoti2
            // 
            this.labelNoti2.AutoSize = true;
            this.labelNoti2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoti2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.labelNoti2.Location = new System.Drawing.Point(18, 74);
            this.labelNoti2.Name = "labelNoti2";
            this.labelNoti2.Size = new System.Drawing.Size(140, 25);
            this.labelNoti2.TabIndex = 35;
            this.labelNoti2.Tag = "";
            this.labelNoti2.Text = "You can login now";
            // 
            // butOKSuccess
            // 
            this.butOKSuccess.BorderRadius = 15;
            this.butOKSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOKSuccess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOKSuccess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOKSuccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOKSuccess.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOKSuccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOKSuccess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butOKSuccess.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butOKSuccess.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOKSuccess.ForeColor = System.Drawing.Color.White;
            this.butOKSuccess.Location = new System.Drawing.Point(65, 133);
            this.butOKSuccess.Name = "butOKSuccess";
            this.butOKSuccess.Size = new System.Drawing.Size(159, 45);
            this.butOKSuccess.TabIndex = 34;
            this.butOKSuccess.Text = "OK";
            this.butOKSuccess.Click += new System.EventHandler(this.butOKSuccess_Click);
            // 
            // labelNoti
            // 
            this.labelNoti.AutoSize = true;
            this.labelNoti.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.labelNoti.Location = new System.Drawing.Point(16, 36);
            this.labelNoti.Name = "labelNoti";
            this.labelNoti.Size = new System.Drawing.Size(193, 38);
            this.labelNoti.TabIndex = 32;
            this.labelNoti.Tag = "";
            this.labelNoti.Text = "Sign up success";
            // 
            // butBack
            // 
            this.butBack.BorderRadius = 4;
            this.butBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butBack.FillColor = System.Drawing.Color.Transparent;
            this.butBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butBack.ForeColor = System.Drawing.Color.White;
            this.butBack.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butBack.Image = ((System.Drawing.Image)(resources.GetObject("butBack.Image")));
            this.butBack.Location = new System.Drawing.Point(-11, 0);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(59, 39);
            this.butBack.TabIndex = 35;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // usVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNoti);
            this.Controls.Add(this.butUSback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butCode);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label7);
            this.Name = "usVerification";
            this.Size = new System.Drawing.Size(347, 536);
            this.Load += new System.EventHandler(this.usVerification_Load);
            this.panelNoti.ResumeLayout(false);
            this.panelNoti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textCode;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton butLogin;
        private System.Windows.Forms.Label labelCode;
        private Guna.UI2.WinForms.Guna2Button butBack;
        private Guna.UI2.WinForms.Guna2GradientButton butCode;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientButton butUSback;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelNoti;
        private Guna.UI2.WinForms.Guna2GradientButton butOKSuccess;
        private System.Windows.Forms.Label labelNoti;
        private System.Windows.Forms.Label labelNoti2;
    }
}
