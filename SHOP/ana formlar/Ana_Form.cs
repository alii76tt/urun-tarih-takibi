using Microsoft.Win32; // Otomatik olarak başlması için kullandığımız kütüphane
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SHOP // https://github.com/alii76tt
{
    public partial class Ana_Form : MetroFramework.Forms.MetroForm
    {
       
        public Ana_Form()
        {    
            InitializeComponent(); 
            // PC Her açıldığında otomatik olarak başlaması için
            string name = "Urün Tarih Takibi";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(name, "\"" + Application.ExecutablePath + "\"");
        }

        Sql_Connection connection = new Sql_Connection();

        public void Ana_Form_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;       
        }
        public string veri { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urun_Ekle frm2 = new Urun_Ekle();
            frm2.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler frm3 = new Urunler();
            frm3.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urun_Guncelle frm4 = new Urun_Guncelle();
            frm4.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunu_Sil frm6 = new Urunu_Sil();
            frm6.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tarihkontrolbutton_Click(object sender, EventArgs e)
        {
            Trih_Kontrol_Form trih_Kontrol_Form = new Trih_Kontrol_Form();
            trih_Kontrol_Form.Show();
            this.Hide();      
        }

        private void ayarlarbutton_Click(object sender, EventArgs e)
        {    
            SqlCommand command = new SqlCommand("Select yetki From Kullanıcılar Where username='" + veri + "'", connection.connection());
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {         
                if (dr["yetki"].ToString() == "True")
                {
                    Ayarlar ayarlar = new Ayarlar();
                    ayarlar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ayarlara Girmek İçin Yeterli Yetkiniz Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
