namespace DoAn.Caro
{
    partial class usMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usMenu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.butBackNoti = new Guna.UI2.WinForms.Guna2Button();
            this.butQuit = new Guna.UI2.WinForms.Guna2Button();
            this.butSound = new Guna.UI2.WinForms.Guna2Button();
            this.butSurrender = new Guna.UI2.WinForms.Guna2Button();
            this.butNewGame = new Guna.UI2.WinForms.Guna2Button();
            this.panelHelp = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 28;
            this.guna2Panel1.Controls.Add(this.panelHelp);
            this.guna2Panel1.Controls.Add(this.butBackNoti);
            this.guna2Panel1.Controls.Add(this.butQuit);
            this.guna2Panel1.Controls.Add(this.butSound);
            this.guna2Panel1.Controls.Add(this.butSurrender);
            this.guna2Panel1.Controls.Add(this.butNewGame);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(440, 577);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // butBackNoti
            // 
            this.butBackNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBackNoti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butBackNoti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butBackNoti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butBackNoti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butBackNoti.FillColor = System.Drawing.Color.Transparent;
            this.butBackNoti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butBackNoti.ForeColor = System.Drawing.Color.White;
            this.butBackNoti.Image = global::DoAn.Properties.Resources.reback_removebg_preview;
            this.butBackNoti.ImageSize = new System.Drawing.Size(40, 40);
            this.butBackNoti.Location = new System.Drawing.Point(178, 49);
            this.butBackNoti.Name = "butBackNoti";
            this.butBackNoti.Size = new System.Drawing.Size(71, 61);
            this.butBackNoti.TabIndex = 27;
            this.butBackNoti.Click += new System.EventHandler(this.butBackNoti_Click);
            // 
            // butQuit
            // 
            this.butQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butQuit.BorderRadius = 19;
            this.butQuit.BorderThickness = 4;
            this.butQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butQuit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butQuit.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuit.ForeColor = System.Drawing.Color.White;
            this.butQuit.Location = new System.Drawing.Point(102, 365);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(223, 68);
            this.butQuit.TabIndex = 3;
            this.butQuit.Text = "QUIT";
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // butSound
            // 
            this.butSound.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butSound.BorderRadius = 19;
            this.butSound.BorderThickness = 4;
            this.butSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSound.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSound.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSound.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butSound.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSound.ForeColor = System.Drawing.Color.White;
            this.butSound.Location = new System.Drawing.Point(102, 282);
            this.butSound.Name = "butSound";
            this.butSound.Size = new System.Drawing.Size(223, 68);
            this.butSound.TabIndex = 2;
            this.butSound.Text = "HELP";
            this.butSound.Click += new System.EventHandler(this.butSound_Click);
            // 
            // butSurrender
            // 
            this.butSurrender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butSurrender.BorderRadius = 19;
            this.butSurrender.BorderThickness = 4;
            this.butSurrender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSurrender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSurrender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSurrender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSurrender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSurrender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butSurrender.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSurrender.ForeColor = System.Drawing.Color.White;
            this.butSurrender.Location = new System.Drawing.Point(102, 199);
            this.butSurrender.Name = "butSurrender";
            this.butSurrender.Size = new System.Drawing.Size(223, 68);
            this.butSurrender.TabIndex = 1;
            this.butSurrender.Text = "SURRENDER";
            this.butSurrender.Click += new System.EventHandler(this.butSurrender_Click);
            // 
            // butNewGame
            // 
            this.butNewGame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.butNewGame.BorderRadius = 19;
            this.butNewGame.BorderThickness = 4;
            this.butNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNewGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNewGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNewGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNewGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNewGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(173)))));
            this.butNewGame.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNewGame.ForeColor = System.Drawing.Color.White;
            this.butNewGame.Location = new System.Drawing.Point(102, 116);
            this.butNewGame.Name = "butNewGame";
            this.butNewGame.Size = new System.Drawing.Size(223, 68);
            this.butNewGame.TabIndex = 0;
            this.butNewGame.Text = "NEW GAME";
            this.butNewGame.Click += new System.EventHandler(this.butNewGame_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.Transparent;
            this.panelHelp.BorderColor = System.Drawing.Color.Navy;
            this.panelHelp.BorderRadius = 20;
            this.panelHelp.BorderThickness = 2;
            this.panelHelp.Controls.Add(this.guna2Button1);
            this.panelHelp.Controls.Add(this.label1);
            this.panelHelp.FillColor = System.Drawing.Color.LightGray;
            this.panelHelp.Location = new System.Drawing.Point(20, 49);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(392, 391);
            this.panelHelp.TabIndex = 28;
            this.panelHelp.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 270);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::DoAn.Properties.Resources.reback_removebg_preview;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(150, 334);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(59, 54);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // usMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "usMenu";
            this.Size = new System.Drawing.Size(502, 580);
            this.guna2Panel1.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button butQuit;
        private Guna.UI2.WinForms.Guna2Button butSound;
        private Guna.UI2.WinForms.Guna2Button butSurrender;
        private Guna.UI2.WinForms.Guna2Button butNewGame;
        private Guna.UI2.WinForms.Guna2Button butBackNoti;
        private Guna.UI2.WinForms.Guna2Panel panelHelp;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}
