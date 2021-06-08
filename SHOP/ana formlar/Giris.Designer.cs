namespace SHOP
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.usernameTextbox = new ns1.BunifuMaterialTextbox();
            this.passwordTextbox = new ns1.BunifuMaterialTextbox();
            this.loginbutton = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHOP.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(174, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SHOP.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(455, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SHOP.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(407, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.usernameTextbox.HintText = "Kullanıcı Adı";
            this.usernameTextbox.isPassword = false;
            this.usernameTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.usernameTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.usernameTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usernameTextbox.LineThickness = 3;
            this.usernameTextbox.Location = new System.Drawing.Point(96, 274);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(298, 53);
            this.usernameTextbox.TabIndex = 4;
            this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.AccessibleDescription = "";
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextbox.HintText = "";
            this.passwordTextbox.isPassword = true;
            this.passwordTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passwordTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordTextbox.LineThickness = 3;
            this.passwordTextbox.Location = new System.Drawing.Point(96, 357);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(298, 53);
            this.passwordTextbox.TabIndex = 0;
            this.passwordTextbox.Tag = "";
            this.passwordTextbox.Text = "Şifre";
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox2_KeyDown);
            // 
            // loginbutton
            // 
            this.loginbutton.ActiveBorderThickness = 1;
            this.loginbutton.ActiveCornerRadius = 20;
            this.loginbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.ActiveForecolor = System.Drawing.Color.White;
            this.loginbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.ButtonText = "Giriş Yap";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.IdleBorderThickness = 1;
            this.loginbutton.IdleCornerRadius = 20;
            this.loginbutton.IdleFillColor = System.Drawing.Color.White;
            this.loginbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.loginbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.Location = new System.Drawing.Point(96, 419);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(5);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(298, 92);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 523);
            this.ControlBox = false;
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(499, 523);
            this.MinimumSize = new System.Drawing.Size(499, 523);
            this.Name = "Giris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public ns1.BunifuMaterialTextbox usernameTextbox;
        public ns1.BunifuMaterialTextbox passwordTextbox;
        public ns1.BunifuThinButton2 loginbutton;
    }
}

