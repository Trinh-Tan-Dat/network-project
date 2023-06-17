namespace DoAn.Chat
{
    partial class usMyMessage
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
            this.panelMessage = new Guna.UI2.WinForms.Guna2Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureAvar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMessage.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.AutoSize = true;
            this.panelMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelMessage.BorderRadius = 15;
            this.panelMessage.Controls.Add(this.lbMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(113)))));
            this.panelMessage.Location = new System.Drawing.Point(502, 5);
            this.panelMessage.MaximumSize = new System.Drawing.Size(515, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Padding = new System.Windows.Forms.Padding(15, 15, 20, 15);
            this.panelMessage.Size = new System.Drawing.Size(254, 174);
            this.panelMessage.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(15, 15);
            this.lbMessage.MaximumSize = new System.Drawing.Size(490, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(219, 29);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "dfdsfdsfdsfdsfdsfds";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoSize = true;
            this.guna2Panel2.Controls.Add(this.pictureAvar);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(756, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(59, 174);
            this.guna2Panel2.TabIndex = 3;
            // 
            // pictureAvar
            // 
            this.pictureAvar.BackColor = System.Drawing.Color.Transparent;
            this.pictureAvar.Image = global::DoAn.Properties.Resources.icons8_user_male_64;
            this.pictureAvar.ImageRotate = 0F;
            this.pictureAvar.Location = new System.Drawing.Point(6, 3);
            this.pictureAvar.Name = "pictureAvar";
            this.pictureAvar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureAvar.Size = new System.Drawing.Size(50, 50);
            this.pictureAvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvar.TabIndex = 2;
            this.pictureAvar.TabStop = false;
            // 
            // usMyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.guna2Panel2);
            this.MinimumSize = new System.Drawing.Size(0, 70);
            this.Name = "usMyMessage";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Size = new System.Drawing.Size(825, 184);
            this.Resize += new System.EventHandler(this.usMyMessage_Resize);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMessage;
        private System.Windows.Forms.Label lbMessage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureAvar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
