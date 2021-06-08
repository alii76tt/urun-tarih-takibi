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

namespace SHOP
{
    public partial class Urun_Ekle : MetroFramework.Forms.MetroForm
    {
        public Urun_Ekle()
        {
            InitializeComponent();
        }

        Ana_Form ana_Form = new Ana_Form();
        Sql_Connection connection = new Sql_Connection();

        private void comboboxvericekme()
        {
            /*Eğer veriyi combobox'a çekmek isterseniz.
            SqlCommand komut = new SqlCommand("Select Urun_CESIDI From Urunler", connect.connection());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                uruncesidComboBox.Items.Add(read[0].ToString());
            }*/
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_Form.Show();
        }

        private void temizleButton_MouseDown(object sender, EventArgs e)
        {
            urunbarkodtextbox.Text = "";
            urunisimtextbox.Text = "";
            uruncesidComboBox.SelectedItem = null;
            uretimtarihiDatepicker.Value = DateTime.Now;
            tuketimDatepicker.Value = DateTime.Now;
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (urunbarkodtextbox.Text ==string.Empty && urunisimtextbox.Text ==string.Empty)
            {
                MessageBox.Show("Lütfen Ürün Bilgilerini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("insert into Urunler (Urun_BARKOD,Urun_ISIM,Urun_CESIDI,Urun_TK_TARIH,Urun_SK_TARIH) values(@p1,@p2,@p3,@p4,@p5)", connection.connection());
                    command.Parameters.AddWithValue("@p1", urunbarkodtextbox.Text);
                    command.Parameters.AddWithValue("@p2", urunisimtextbox.Text.ToString());
                    command.Parameters.AddWithValue("@p3", uruncesidComboBox.Text.ToString());
                    command.Parameters.AddWithValue("@p4", uretimtarihiDatepicker.Value);
                    command.Parameters.AddWithValue("@p5", tuketimDatepicker.Value);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Ürün Başarılı Bir Şekilde Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ürün Kaydı Yapılamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.urunlerTableAdapter.FillBy(this.urun_Tarih_TakibiDataSet1.Urunler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
