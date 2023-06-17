namespace DoAn.usLogin
{
    partial class usCodeChange
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
            this.panelCode = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNoti = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNoti2 = new System.Windows.Forms.Label();
            this.butOKSuccess = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelNoti = new System.Windows.Forms.Label();
            this.butCode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butBack = new Guna.UI2.WinForms.Guna2Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.butConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCode.SuspendLayout();
            this.panelNoti.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.panelNoti);
            this.panelCode.Controls.Add(this.butCode);
            this.panelCode.Controls.Add(this.butBack);
            this.panelCode.Controls.Add(this.labelCode);
            this.panelCode.Controls.Add(this.butConfirm);
            this.panelCode.Controls.Add(this.textCode);
            this.panelCode.Controls.Add(this.label7);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCode.Location = new System.Drawing.Point(0, 0);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(347, 536);
            this.panelCode.TabIndex = 50;
            // 
            // panelNoti
            // 
            this.panelNoti.Controls.Add(this.labelNoti2);
            this.panelNoti.Controls.Add(this.butOKSuccess);
            this.panelNoti.Controls.Add(this.labelNoti);
            this.panelNoti.Location = new System.Drawing.Point(20, 129);
            this.panelNoti.Name = "panelNoti";
            this.panelNoti.Size = new System.Drawing.Size(315, 207);
            this.panelNoti.TabIndex = 47;
            this.panelNoti.Visible = false;
            // 
            // labelNoti2
            // 
            this.labelNoti2.AutoSize = true;
            this.labelNoti2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoti2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.labelNoti2.Location = new System.Drawing.Point(18, 74);
            this.labelNoti2.Name = "labelNoti2";
            this.labelNoti2.Size = new System.Drawing.Size(125, 25);
            this.labelNoti2.TabIndex = 35;
            this.labelNoti2.Tag = "";
            this.labelNoti2.Text = "Check your OTP";
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
            this.labelNoti.Size = new System.Drawing.Size(146, 38);
            this.labelNoti.TabIndex = 32;
            this.labelNoti.Tag = "";
            this.labelNoti.Text = "Wrong code";
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
            this.butCode.TabIndex = 44;
            this.butCode.Text = "Send again";
            this.butCode.Click += new System.EventHandler(this.butCode_Click);
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
            this.butBack.Image = global::DoAn.Properties.Resources.backIcon;
            this.butBack.Location = new System.Drawing.Point(-11, 0);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(59, 39);
            this.butBack.TabIndex = 43;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.Color.Red;
            this.labelCode.Location = new System.Drawing.Point(17, 198);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(107, 17);
            this.labelCode.TabIndex = 42;
            this.labelCode.Tag = "";
            this.labelCode.Text = "Please input code";
            this.labelCode.Visible = false;
            // 
            // butConfirm
            // 
            this.butConfirm.BorderRadius = 15;
            this.butConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butConfirm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butConfirm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfirm.ForeColor = System.Drawing.Color.White;
            this.butConfirm.Location = new System.Drawing.Point(43, 238);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(229, 45);
            this.butConfirm.TabIndex = 41;
            this.butConfirm.Text = "OK";
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
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
            this.textCode.TabIndex = 40;
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
            this.label7.TabIndex = 39;
            this.label7.Tag = "";
            this.label7.Text = "Verification Code";
            // 
            // usCodeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCode);
            this.Name = "usCodeChange";
            this.Size = new System.Drawing.Size(347, 536);
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panelNoti.ResumeLayout(false);
            this.panelNoti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCode;
        private Guna.UI2.WinForms.Guna2Panel panelNoti;
        private System.Windows.Forms.Label labelNoti2;
        private Guna.UI2.WinForms.Guna2GradientButton butOKSuccess;
        private System.Windows.Forms.Label labelNoti;
        private Guna.UI2.WinForms.Guna2GradientButton butCode;
        private Guna.UI2.WinForms.Guna2Button butBack;
        private System.Windows.Forms.Label labelCode;
        private Guna.UI2.WinForms.Guna2GradientButton butConfirm;
        private Guna.UI2.WinForms.Guna2TextBox textCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
