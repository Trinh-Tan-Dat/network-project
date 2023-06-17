namespace DoAn.TabHome
{
    partial class fTabGameRoom
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelEach = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.butCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelMainLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.usWaiting1 = new DoAn.Notification.usWaiting();
            this.panelMainRight = new Guna.UI2.WinForms.Guna2Panel();
            this.panelEach.SuspendLayout();
            this.panelMainLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelEach
            // 
            this.panelEach.BorderColor = System.Drawing.Color.Transparent;
            this.panelEach.BorderRadius = 20;
            this.panelEach.Controls.Add(this.butCreate);
            this.panelEach.Controls.Add(this.butRefresh);
            this.panelEach.Controls.Add(this.labelEmail);
            this.panelEach.Controls.Add(this.labelName);
            this.panelEach.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.Location = new System.Drawing.Point(10, 0);
            this.panelEach.MaximumSize = new System.Drawing.Size(1054, 80);
            this.panelEach.MinimumSize = new System.Drawing.Size(1054, 55);
            this.panelEach.Name = "panelEach";
            this.panelEach.Size = new System.Drawing.Size(1054, 78);
            this.panelEach.TabIndex = 39;
            this.panelEach.Tag = "0";
            // 
            // butCreate
            // 
            this.butCreate.BackColor = System.Drawing.Color.Transparent;
            this.butCreate.BorderRadius = 10;
            this.butCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCreate.FillColor = System.Drawing.Color.White;
            this.butCreate.FillColor2 = System.Drawing.Color.White;
            this.butCreate.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.butCreate.Location = new System.Drawing.Point(927, 43);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(115, 29);
            this.butCreate.TabIndex = 28;
            this.butCreate.Text = "Create room";
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.Transparent;
            this.butRefresh.BorderRadius = 10;
            this.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butRefresh.FillColor = System.Drawing.Color.White;
            this.butRefresh.FillColor2 = System.Drawing.Color.White;
            this.butRefresh.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.butRefresh.Location = new System.Drawing.Point(927, 5);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(115, 29);
            this.butRefresh.TabIndex = 27;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(344, 49);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(271, 23);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Only support for same LAN";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(317, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(325, 55);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "List of playroom";
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.AutoScroll = true;
            this.panelMainLeft.Controls.Add(this.usWaiting1);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainLeft.Location = new System.Drawing.Point(10, 78);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelMainLeft.Size = new System.Drawing.Size(528, 533);
            this.panelMainLeft.TabIndex = 41;
            // 
            // usWaiting1
            // 
            this.usWaiting1.BackColor = System.Drawing.Color.Transparent;
            this.usWaiting1.Location = new System.Drawing.Point(389, 145);
            this.usWaiting1.Name = "usWaiting1";
            this.usWaiting1.Size = new System.Drawing.Size(139, 131);
            this.usWaiting1.TabIndex = 0;
            // 
            // panelMainRight
            // 
            this.panelMainRight.AutoScroll = true;
            this.panelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainRight.Location = new System.Drawing.Point(538, 78);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelMainRight.Size = new System.Drawing.Size(528, 533);
            this.panelMainRight.TabIndex = 42;
            // 
            // fTabGameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Controls.Add(this.panelMainRight);
            this.Controls.Add(this.panelMainLeft);
            this.Controls.Add(this.panelEach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTabGameRoom";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.Text = "fTabGameRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTabGameRoom_FormClosing);
            this.Load += new System.EventHandler(this.fTabGameRoom_Load);
            this.panelEach.ResumeLayout(false);
            this.panelEach.PerformLayout();
            this.panelMainLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEach;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private Guna.UI2.WinForms.Guna2Panel panelMainLeft;
        private Guna.UI2.WinForms.Guna2Panel panelMainRight;
        public Notification.usWaiting usWaiting1;
        private Guna.UI2.WinForms.Guna2GradientButton butCreate;
        private Guna.UI2.WinForms.Guna2GradientButton butRefresh;
    }
}