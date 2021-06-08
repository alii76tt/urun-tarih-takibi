namespace SHOP
{
    partial class Urun_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun_Ekle));
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.urunbarkodtextbox = new ns1.BunifuMetroTextbox();
            this.urunisimtextbox = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.uretimtarihiDatepicker = new ns1.BunifuDatepicker();
            this.tuketimDatepicker = new ns1.BunifuDatepicker();
            this.uruncesidComboBox = new MetroFramework.Controls.MetroComboBox();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urun_Tarih_TakibiDataSet1 = new SHOP.Urun_Tarih_TakibiDataSet1();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.temizleButton = new ns1.BunifuFlatButton();
            this.kaydetButton = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.urunlerTableAdapter = new SHOP.Urun_Tarih_TakibiDataSet1TableAdapters.UrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Tarih_TakibiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 120);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(200, 32);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Ürün Barkodu:";
            // 
            // urunbarkodtextbox
            // 
            this.urunbarkodtextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.urunbarkodtextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.urunbarkodtextbox.BorderThickness = 3;
            this.urunbarkodtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urunbarkodtextbox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunbarkodtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtextbox.isPassword = false;
            this.urunbarkodtextbox.Location = new System.Drawing.Point(486, 81);
            this.urunbarkodtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.urunbarkodtextbox.Name = "urunbarkodtextbox";
            this.urunbarkodtextbox.Size = new System.Drawing.Size(300, 71);
            this.urunbarkodtextbox.TabIndex = 1;
            this.urunbarkodtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // urunisimtextbox
            // 
            this.urunisimtextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.urunisimtextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunisimtextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.urunisimtextbox.BorderThickness = 3;
            this.urunisimtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urunisimtextbox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunisimtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunisimtextbox.isPassword = false;
            this.urunisimtextbox.Location = new System.Drawing.Point(486, 160);
            this.urunisimtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.urunisimtextbox.Name = "urunisimtextbox";
            this.urunisimtextbox.Size = new System.Drawing.Size(300, 72);
            this.urunisimtextbox.TabIndex = 3;
            this.urunisimtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 200);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(147, 32);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Ürün İsimi:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 269);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(170, 32);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Ürün Çeşidi:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 350);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(180, 32);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Üretim Tarihi:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 427);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(251, 32);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Son Tüketim Tarihi:";
            // 
            // uretimtarihiDatepicker
            // 
            this.uretimtarihiDatepicker.BackColor = System.Drawing.Color.Green;
            this.uretimtarihiDatepicker.BorderRadius = 0;
            this.uretimtarihiDatepicker.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretimtarihiDatepicker.ForeColor = System.Drawing.Color.White;
            this.uretimtarihiDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.uretimtarihiDatepicker.FormatCustom = null;
            this.uretimtarihiDatepicker.Location = new System.Drawing.Point(487, 318);
            this.uretimtarihiDatepicker.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.uretimtarihiDatepicker.Name = "uretimtarihiDatepicker";
            this.uretimtarihiDatepicker.Size = new System.Drawing.Size(300, 75);
            this.uretimtarihiDatepicker.TabIndex = 9;
            this.uretimtarihiDatepicker.Value = new System.DateTime(2021, 5, 2, 22, 10, 52, 606);
            // 
            // tuketimDatepicker
            // 
            this.tuketimDatepicker.BackColor = System.Drawing.Color.DarkRed;
            this.tuketimDatepicker.BorderRadius = 0;
            this.tuketimDatepicker.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tuketimDatepicker.ForeColor = System.Drawing.Color.White;
            this.tuketimDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tuketimDatepicker.FormatCustom = "";
            this.tuketimDatepicker.Location = new System.Drawing.Point(487, 399);
            this.tuketimDatepicker.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tuketimDatepicker.Name = "tuketimDatepicker";
            this.tuketimDatepicker.Size = new System.Drawing.Size(300, 75);
            this.tuketimDatepicker.TabIndex = 10;
            this.tuketimDatepicker.Value = new System.DateTime(2021, 5, 4, 0, 0, 0, 0);
            // 
            // uruncesidComboBox
            // 
            this.uruncesidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.urunlerBindingSource, "Urun_CESIDI", true));
            this.uruncesidComboBox.DropDownHeight = 200;
            this.uruncesidComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.uruncesidComboBox.FormattingEnabled = true;
            this.uruncesidComboBox.IntegralHeight = false;
            this.uruncesidComboBox.ItemHeight = 23;
            this.uruncesidComboBox.Items.AddRange(new object[] {
            "Atıştırmalık Ürünler",
            "Et ve Et Ürünleri",
            "İçecek",
            "Kağıt Ürünleri",
            "Kozmetik ve Kişisel Bakım",
            "Meyve Sebze",
            "Süt ve Süt Ürünleri",
            "Şarküteri ve Kahvaltılık",
            "Temel Gıda",
            "Temizlik Ürünleri"});
            this.uruncesidComboBox.Location = new System.Drawing.Point(487, 269);
            this.uruncesidComboBox.Name = "uruncesidComboBox";
            this.uruncesidComboBox.Size = new System.Drawing.Size(300, 29);
            this.uruncesidComboBox.TabIndex = 11;
            this.uruncesidComboBox.UseSelectable = true;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urun_Tarih_TakibiDataSet1;
            // 
            // urun_Tarih_TakibiDataSet1
            // 
            this.urun_Tarih_TakibiDataSet1.DataSetName = "Urun_Tarih_TakibiDataSet1";
            this.urun_Tarih_TakibiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backBox
            // 
            this.backBox.Image = global::SHOP.Properties.Resources.previous;
            this.backBox.Location = new System.Drawing.Point(0, 6);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(42, 41);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBox.TabIndex = 19;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = global::SHOP.Properties.Resources.minimize;
            this.minimizeBox.Location = new System.Drawing.Point(720, 6);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(42, 41);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBox.TabIndex = 18;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // closeBox
            // 
            this.closeBox.Image = global::SHOP.Properties.Resources.cancel;
            this.closeBox.Location = new System.Drawing.Point(768, 6);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(42, 41);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 17;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.temizleButton.BackColor = System.Drawing.Color.Maroon;
            this.temizleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.temizleButton.BorderRadius = 0;
            this.temizleButton.ButtonText = "TEMİZLE";
            this.temizleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizleButton.DisabledColor = System.Drawing.Color.Gray;
            this.temizleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.temizleButton.Iconimage = global::SHOP.Properties.Resources.edit_clear;
            this.temizleButton.Iconimage_right = null;
            this.temizleButton.Iconimage_right_Selected = null;
            this.temizleButton.Iconimage_Selected = null;
            this.temizleButton.IconMarginLeft = 0;
            this.temizleButton.IconMarginRight = 0;
            this.temizleButton.IconRightVisible = true;
            this.temizleButton.IconRightZoom = 0D;
            this.temizleButton.IconVisible = true;
            this.temizleButton.IconZoom = 95D;
            this.temizleButton.IsTab = false;
            this.temizleButton.Location = new System.Drawing.Point(512, 548);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Normalcolor = System.Drawing.Color.Maroon;
            this.temizleButton.OnHovercolor = System.Drawing.Color.Red;
            this.temizleButton.OnHoverTextColor = System.Drawing.Color.White;
            this.temizleButton.selected = false;
            this.temizleButton.Size = new System.Drawing.Size(274, 75);
            this.temizleButton.TabIndex = 15;
            this.temizleButton.Text = "TEMİZLE";
            this.temizleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temizleButton.Textcolor = System.Drawing.Color.White;
            this.temizleButton.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temizleButton.MouseDown += new System.EventHandler(this.temizleButton_MouseDown);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kaydetButton.BackColor = System.Drawing.Color.DarkGreen;
            this.kaydetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kaydetButton.BorderRadius = 0;
            this.kaydetButton.ButtonText = "KAYDET";
            this.kaydetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetButton.DisabledColor = System.Drawing.Color.Gray;
            this.kaydetButton.Iconcolor = System.Drawing.Color.Transparent;
            this.kaydetButton.Iconimage = global::SHOP.Properties.Resources.add;
            this.kaydetButton.Iconimage_right = null;
            this.kaydetButton.Iconimage_right_Selected = null;
            this.kaydetButton.Iconimage_Selected = null;
            this.kaydetButton.IconMarginLeft = 0;
            this.kaydetButton.IconMarginRight = 0;
            this.kaydetButton.IconRightVisible = true;
            this.kaydetButton.IconRightZoom = 0D;
            this.kaydetButton.IconVisible = true;
            this.kaydetButton.IconZoom = 90D;
            this.kaydetButton.IsTab = false;
            this.kaydetButton.Location = new System.Drawing.Point(14, 548);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Normalcolor = System.Drawing.Color.DarkGreen;
            this.kaydetButton.OnHovercolor = System.Drawing.Color.Lime;
            this.kaydetButton.OnHoverTextColor = System.Drawing.Color.White;
            this.kaydetButton.selected = false;
            this.kaydetButton.Size = new System.Drawing.Size(274, 75);
            this.kaydetButton.TabIndex = 14;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetButton.Textcolor = System.Drawing.Color.White;
            this.kaydetButton.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "KAYDET";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1524, 493);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(581, 199);
            this.bunifuFlatButton2.TabIndex = 13;
            this.bunifuFlatButton2.Text = "KAYDET";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Urun_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 646);
            this.ControlBox = false;
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.uruncesidComboBox);
            this.Controls.Add(this.tuketimDatepicker);
            this.Controls.Add(this.uretimtarihiDatepicker);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.urunisimtextbox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.urunbarkodtextbox);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(810, 646);
            this.MinimumSize = new System.Drawing.Size(810, 646);
            this.Name = "Urun_Ekle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Yeni Ürün Ekle";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Tarih_TakibiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMetroTextbox urunbarkodtextbox;
        private ns1.BunifuMetroTextbox urunisimtextbox;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuDatepicker uretimtarihiDatepicker;
        private ns1.BunifuDatepicker tuketimDatepicker;
        private MetroFramework.Controls.MetroComboBox uruncesidComboBox;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton kaydetButton;
        private ns1.BunifuFlatButton temizleButton;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox backBox;
        private Urun_Tarih_TakibiDataSet1 urun_Tarih_TakibiDataSet1;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private Urun_Tarih_TakibiDataSet1TableAdapters.UrunlerTableAdapter urunlerTableAdapter;
    }
}