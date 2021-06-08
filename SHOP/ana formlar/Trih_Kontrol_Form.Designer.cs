namespace SHOP
{
    partial class Trih_Kontrol_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trih_Kontrol_Form));
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunbarkodtext = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.kontroletButton = new ns1.BunifuFlatButton();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(18, 194);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 28);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "Tarih: ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(104, 194);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 25);
            this.bunifuCustomLabel1.TabIndex = 27;
            this.bunifuCustomLabel1.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 401);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urunbarkodtext
            // 
            this.urunbarkodtext.BorderColorFocused = System.Drawing.Color.Blue;
            this.urunbarkodtext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtext.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.urunbarkodtext.BorderThickness = 3;
            this.urunbarkodtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urunbarkodtext.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunbarkodtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtext.isPassword = false;
            this.urunbarkodtext.Location = new System.Drawing.Point(176, 94);
            this.urunbarkodtext.Margin = new System.Windows.Forms.Padding(4);
            this.urunbarkodtext.Name = "urunbarkodtext";
            this.urunbarkodtext.Size = new System.Drawing.Size(264, 48);
            this.urunbarkodtext.TabIndex = 39;
            this.urunbarkodtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 19);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Ürün Barkodu:";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "TÜM ÜRÜNLERİ KONTROL ET ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SHOP.Properties.Resources.checksproducts;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 92D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(491, 148);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(419, 68);
            this.bunifuFlatButton2.TabIndex = 42;
            this.bunifuFlatButton2.Text = "TÜM ÜRÜNLERİ KONTROL ET ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // kontroletButton
            // 
            this.kontroletButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kontroletButton.BackColor = System.Drawing.Color.DarkGreen;
            this.kontroletButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kontroletButton.BorderRadius = 0;
            this.kontroletButton.ButtonText = "ÜRÜNÜ KONTROL ET";
            this.kontroletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kontroletButton.DisabledColor = System.Drawing.Color.Gray;
            this.kontroletButton.Iconcolor = System.Drawing.Color.Transparent;
            this.kontroletButton.Iconimage = global::SHOP.Properties.Resources.monitoring;
            this.kontroletButton.Iconimage_right = null;
            this.kontroletButton.Iconimage_right_Selected = null;
            this.kontroletButton.Iconimage_Selected = null;
            this.kontroletButton.IconMarginLeft = 0;
            this.kontroletButton.IconMarginRight = 0;
            this.kontroletButton.IconRightVisible = true;
            this.kontroletButton.IconRightZoom = 0D;
            this.kontroletButton.IconVisible = true;
            this.kontroletButton.IconZoom = 92D;
            this.kontroletButton.IsTab = false;
            this.kontroletButton.Location = new System.Drawing.Point(491, 74);
            this.kontroletButton.Name = "kontroletButton";
            this.kontroletButton.Normalcolor = System.Drawing.Color.DarkGreen;
            this.kontroletButton.OnHovercolor = System.Drawing.Color.Lime;
            this.kontroletButton.OnHoverTextColor = System.Drawing.Color.White;
            this.kontroletButton.selected = false;
            this.kontroletButton.Size = new System.Drawing.Size(419, 68);
            this.kontroletButton.TabIndex = 29;
            this.kontroletButton.Text = "ÜRÜNÜ KONTROL ET";
            this.kontroletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kontroletButton.Textcolor = System.Drawing.Color.White;
            this.kontroletButton.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontroletButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // backBox
            // 
            this.backBox.Image = global::SHOP.Properties.Resources.previous;
            this.backBox.Location = new System.Drawing.Point(-1, 5);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(42, 41);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBox.TabIndex = 26;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.backBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SHOP.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(832, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::SHOP.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(880, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Trih_Kontrol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 622);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.urunbarkodtext);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kontroletButton);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(923, 622);
            this.MinimumSize = new System.Drawing.Size(923, 622);
            this.Name = "Trih_Kontrol_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Tarih Kontrolü Yap";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Trih_Kontrol_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox backBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton kontroletButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuMetroTextbox urunbarkodtext;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuFlatButton bunifuFlatButton2;
    }
}