namespace SHOP
{
    partial class Ana_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.versiyonlabel = new ns1.BunifuCustomLabel();
            this.tarihkontrolbutton = new ns1.BunifuTileButton();
            this.ayarlarButton = new ns1.BunifuTileButton();
            this.urunsilButton = new ns1.BunifuTileButton();
            this.urunguncelleButton = new ns1.BunifuTileButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.urunlerButton = new ns1.BunifuTileButton();
            this.urunekleButton = new ns1.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(180, 594);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 25);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "tarih";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(94, 591);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 28);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Tarih: ";
            // 
            // versiyonlabel
            // 
            this.versiyonlabel.AutoSize = true;
            this.versiyonlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versiyonlabel.Location = new System.Drawing.Point(856, 603);
            this.versiyonlabel.Name = "versiyonlabel";
            this.versiyonlabel.Size = new System.Drawing.Size(66, 14);
            this.versiyonlabel.TabIndex = 10;
            this.versiyonlabel.Text = "Sürüm 1.0";
            // 
            // tarihkontrolbutton
            // 
            this.tarihkontrolbutton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tarihkontrolbutton.BackColor = System.Drawing.Color.MidnightBlue;
            this.tarihkontrolbutton.color = System.Drawing.Color.MidnightBlue;
            this.tarihkontrolbutton.colorActive = System.Drawing.Color.DarkMagenta;
            this.tarihkontrolbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarihkontrolbutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihkontrolbutton.ForeColor = System.Drawing.Color.White;
            this.tarihkontrolbutton.Image = global::SHOP.Properties.Resources.compliant;
            this.tarihkontrolbutton.ImagePosition = 28;
            this.tarihkontrolbutton.ImageZoom = 50;
            this.tarihkontrolbutton.LabelPosition = 57;
            this.tarihkontrolbutton.LabelText = "Tarih Kontrolü ";
            this.tarihkontrolbutton.Location = new System.Drawing.Point(99, 96);
            this.tarihkontrolbutton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tarihkontrolbutton.Name = "tarihkontrolbutton";
            this.tarihkontrolbutton.Size = new System.Drawing.Size(223, 220);
            this.tarihkontrolbutton.TabIndex = 12;
            this.tarihkontrolbutton.Click += new System.EventHandler(this.tarihkontrolbutton_Click);
            // 
            // ayarlarButton
            // 
            this.ayarlarButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ayarlarButton.color = System.Drawing.Color.MidnightBlue;
            this.ayarlarButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.ayarlarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayarlarButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarlarButton.ForeColor = System.Drawing.Color.White;
            this.ayarlarButton.Image = global::SHOP.Properties.Resources.settings1;
            this.ayarlarButton.ImagePosition = 25;
            this.ayarlarButton.ImageZoom = 50;
            this.ayarlarButton.LabelPosition = 52;
            this.ayarlarButton.LabelText = "Ayarlar ";
            this.ayarlarButton.Location = new System.Drawing.Point(631, 330);
            this.ayarlarButton.Margin = new System.Windows.Forms.Padding(7);
            this.ayarlarButton.Name = "ayarlarButton";
            this.ayarlarButton.Size = new System.Drawing.Size(224, 220);
            this.ayarlarButton.TabIndex = 11;
            this.ayarlarButton.Click += new System.EventHandler(this.ayarlarbutton_Click);
            // 
            // urunsilButton
            // 
            this.urunsilButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.urunsilButton.color = System.Drawing.Color.MidnightBlue;
            this.urunsilButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.urunsilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urunsilButton.Font = new System.Drawing.Font("Century Gothic", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunsilButton.ForeColor = System.Drawing.Color.White;
            this.urunsilButton.Image = global::SHOP.Properties.Resources.trash;
            this.urunsilButton.ImagePosition = 27;
            this.urunsilButton.ImageZoom = 50;
            this.urunsilButton.LabelPosition = 55;
            this.urunsilButton.LabelText = "Ürün Sil";
            this.urunsilButton.Location = new System.Drawing.Point(369, 329);
            this.urunsilButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.urunsilButton.Name = "urunsilButton";
            this.urunsilButton.Size = new System.Drawing.Size(223, 221);
            this.urunsilButton.TabIndex = 7;
            this.urunsilButton.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // urunguncelleButton
            // 
            this.urunguncelleButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.urunguncelleButton.color = System.Drawing.Color.MidnightBlue;
            this.urunguncelleButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.urunguncelleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urunguncelleButton.Font = new System.Drawing.Font("Century Gothic", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunguncelleButton.ForeColor = System.Drawing.Color.White;
            this.urunguncelleButton.Image = global::SHOP.Properties.Resources.browser;
            this.urunguncelleButton.ImagePosition = 27;
            this.urunguncelleButton.ImageZoom = 50;
            this.urunguncelleButton.LabelPosition = 55;
            this.urunguncelleButton.LabelText = "Ürün Güncelle";
            this.urunguncelleButton.Location = new System.Drawing.Point(99, 328);
            this.urunguncelleButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.urunguncelleButton.Name = "urunguncelleButton";
            this.urunguncelleButton.Size = new System.Drawing.Size(223, 220);
            this.urunguncelleButton.TabIndex = 6;
            this.urunguncelleButton.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SHOP.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(832, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::SHOP.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(880, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // urunlerButton
            // 
            this.urunlerButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.urunlerButton.color = System.Drawing.Color.MidnightBlue;
            this.urunlerButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.urunlerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urunlerButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerButton.ForeColor = System.Drawing.Color.White;
            this.urunlerButton.Image = global::SHOP.Properties.Resources.stand;
            this.urunlerButton.ImagePosition = 30;
            this.urunlerButton.ImageZoom = 50;
            this.urunlerButton.LabelPosition = 62;
            this.urunlerButton.LabelText = "Ürünler";
            this.urunlerButton.Location = new System.Drawing.Point(631, 96);
            this.urunlerButton.Margin = new System.Windows.Forms.Padding(7);
            this.urunlerButton.Name = "urunlerButton";
            this.urunlerButton.Size = new System.Drawing.Size(224, 220);
            this.urunlerButton.TabIndex = 1;
            this.urunlerButton.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // urunekleButton
            // 
            this.urunekleButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.urunekleButton.color = System.Drawing.Color.MidnightBlue;
            this.urunekleButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.urunekleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urunekleButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunekleButton.ForeColor = System.Drawing.Color.White;
            this.urunekleButton.Image = global::SHOP.Properties.Resources.box;
            this.urunekleButton.ImagePosition = 30;
            this.urunekleButton.ImageZoom = 50;
            this.urunekleButton.LabelPosition = 62;
            this.urunekleButton.LabelText = "Ürün Ekle";
            this.urunekleButton.Location = new System.Drawing.Point(369, 96);
            this.urunekleButton.Margin = new System.Windows.Forms.Padding(7);
            this.urunekleButton.Name = "urunekleButton";
            this.urunekleButton.Size = new System.Drawing.Size(224, 220);
            this.urunekleButton.TabIndex = 0;
            this.urunekleButton.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // Ana_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 622);
            this.ControlBox = false;
            this.Controls.Add(this.tarihkontrolbutton);
            this.Controls.Add(this.ayarlarButton);
            this.Controls.Add(this.versiyonlabel);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.urunsilButton);
            this.Controls.Add(this.urunguncelleButton);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.urunlerButton);
            this.Controls.Add(this.urunekleButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(923, 622);
            this.MinimumSize = new System.Drawing.Size(923, 622);
            this.Name = "Ana_Form";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Ürün Tarih Takibi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Ana_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuTileButton urunekleButton;
        private ns1.BunifuTileButton urunlerButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuTileButton urunguncelleButton;
        private ns1.BunifuTileButton urunsilButton;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel versiyonlabel;
        private ns1.BunifuTileButton tarihkontrolbutton;
        private ns1.BunifuTileButton ayarlarButton;
    }
}