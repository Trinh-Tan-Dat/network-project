namespace DoAn.TabHome
{
    partial class fTabAdmin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.butRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSTT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEach = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.usWaiting1 = new DoAn.Notification.usWaiting();
            this.guna2Panel1.SuspendLayout();
            this.panelEach.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.butRefresh);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 568);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1061, 43);
            this.guna2Panel1.TabIndex = 5;
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.Transparent;
            this.butRefresh.BorderRadius = 15;
            this.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butRefresh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butRefresh.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.ForeColor = System.Drawing.Color.White;
            this.butRefresh.Location = new System.Drawing.Point(424, 9);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(112, 34);
            this.butRefresh.TabIndex = 23;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(502, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(84, 23);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "Gender";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(186, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 23);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Name";
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.BackColor = System.Drawing.Color.Transparent;
            this.labelSTT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTT.ForeColor = System.Drawing.Color.White;
            this.labelSTT.Location = new System.Drawing.Point(23, 19);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(36, 23);
            this.labelSTT.TabIndex = 27;
            this.labelSTT.Text = "STT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(701, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Email";
            // 
            // panelEach
            // 
            this.panelEach.BorderColor = System.Drawing.Color.Transparent;
            this.panelEach.BorderRadius = 20;
            this.panelEach.Controls.Add(this.label1);
            this.panelEach.Controls.Add(this.labelSTT);
            this.panelEach.Controls.Add(this.labelName);
            this.panelEach.Controls.Add(this.labelGender);
            this.panelEach.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.panelEach.Location = new System.Drawing.Point(10, 0);
            this.panelEach.MaximumSize = new System.Drawing.Size(1054, 55);
            this.panelEach.MinimumSize = new System.Drawing.Size(1054, 55);
            this.panelEach.Name = "panelEach";
            this.panelEach.Size = new System.Drawing.Size(1054, 55);
            this.panelEach.TabIndex = 38;
            this.panelEach.Tag = "0";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.usWaiting1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1061, 513);
            this.panelMain.TabIndex = 39;
            // 
            // usWaiting1
            // 
            this.usWaiting1.Location = new System.Drawing.Point(424, 144);
            this.usWaiting1.Name = "usWaiting1";
            this.usWaiting1.Size = new System.Drawing.Size(139, 131);
            this.usWaiting1.TabIndex = 0;
            this.usWaiting1.Visible = false;
            // 
            // fTabAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEach);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTabAdmin";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "tabAdmin";
            this.Load += new System.EventHandler(this.fTabAdmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelEach.ResumeLayout(false);
            this.panelEach.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Notification.usWaiting usWaiting1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelEach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private Guna.UI2.WinForms.Guna2GradientButton butRefresh;
    }
}