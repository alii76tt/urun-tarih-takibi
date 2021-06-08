namespace SHOP
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.urunbarkodtxt = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.temizleButton = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // urunbarkodtxt
            // 
            this.urunbarkodtxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.urunbarkodtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.urunbarkodtxt.BorderThickness = 3;
            this.urunbarkodtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urunbarkodtxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunbarkodtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunbarkodtxt.isPassword = false;
            this.urunbarkodtxt.Location = new System.Drawing.Point(137, 140);
            this.urunbarkodtxt.Margin = new System.Windows.Forms.Padding(4);
            this.urunbarkodtxt.Name = "urunbarkodtxt";
            this.urunbarkodtxt.Size = new System.Drawing.Size(264, 48);
            this.urunbarkodtxt.TabIndex = 3;
            this.urunbarkodtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 152);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Ürün Barkodu:";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 448);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHOP.Properties.Resources.previous;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SHOP.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(863, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SHOP.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(911, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "ÜRÜNÜ ARA";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SHOP.Properties.Resources.loupe;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(496, 138);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(368, 50);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = "ÜRÜNÜ ARA";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "TÜM ÜRÜNLERİ GÖSTER";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::SHOP.Properties.Resources.checking;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(496, 194);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(368, 50);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "TÜM ÜRÜNLERİ GÖSTER";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 217);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 28);
            this.bunifuCustomLabel3.TabIndex = 25;
            this.bunifuCustomLabel3.Text = "Tarih: ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(95, 220);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 25);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.temizleButton.IconZoom = 96D;
            this.temizleButton.IsTab = false;
            this.temizleButton.Location = new System.Drawing.Point(496, 82);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Normalcolor = System.Drawing.Color.Maroon;
            this.temizleButton.OnHovercolor = System.Drawing.Color.Red;
            this.temizleButton.OnHoverTextColor = System.Drawing.Color.White;
            this.temizleButton.selected = false;
            this.temizleButton.Size = new System.Drawing.Size(368, 50);
            this.temizleButton.TabIndex = 36;
            this.temizleButton.Text = "TEMİZLE";
            this.temizleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temizleButton.Textcolor = System.Drawing.Color.White;
            this.temizleButton.TextFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 698);
            this.ControlBox = false;
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.urunbarkodtxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(953, 698);
            this.MinimumSize = new System.Drawing.Size(953, 698);
            this.Name = "Urunler";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ürünler";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMetroTextbox urunbarkodtxt;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuFlatButton temizleButton;
        public ns1.BunifuFlatButton bunifuFlatButton3;
    }
}