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
    public partial class Urunu_Sil : MetroFramework.Forms.MetroForm
    {
        public Urunu_Sil()
        {
            InitializeComponent();
        }

        Sql_Connection connection = new Sql_Connection();
        Ana_Form ana_Form = new Ana_Form();

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_Form.Show();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Urunler Order By Urun_SK_TARIH asc", connection.connection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜRÜN BARKODU";
            dataGridView1.Columns[2].HeaderText = "ÜRÜN İSMİ";
            dataGridView1.Columns[3].HeaderText = "ÜRÜN ÇEŞİDİ";
            dataGridView1.Columns[4].HeaderText = "ÜRETİM TARİHİ";
            dataGridView1.Columns[5].HeaderText = "SON TÜKETİM TARİHİ";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) > Convert.ToDateTime(DateTime.Today) || Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) == Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) < Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.Red;
                }
                else
                {
                    rowColor.BackColor = Color.Salmon;
                }

                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *From Urunler Where Urun_BARKOD='" + urunbarkodtext.Text + "'", connection.connection());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ÜRÜN BARKODU";
            dataGridView1.Columns[2].HeaderText = "ÜRÜN İSMİ";
            dataGridView1.Columns[3].HeaderText = "ÜRÜN ÇEŞİDİ";
            dataGridView1.Columns[4].HeaderText = "ÜRETİM TARİHİ";
            dataGridView1.Columns[5].HeaderText = "SON TÜKETİM TARİHİ";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) > Convert.ToDateTime(DateTime.Today) || Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) == Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) < Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.Red;
                }
                else
                {
                    rowColor.BackColor = Color.Salmon;
                }
                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (urunbarkodtext.Text == string.Empty && urunidMetroTextbox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Silinecek Ürünü Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Delete From Urunler Where ID=@p1", connection.connection());
                    command.Parameters.AddWithValue("@p1", Convert.ToInt32(urunidMetroTextbox1.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ürün Silme Yapılamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunbarkodtext.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            urunidMetroTextbox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Tüm Ürünleri Silmek İstediğinize Emin Misiniz? Bu İşlem Geri Alınamaz.", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel);

            if (result==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Truncate table Urunler", connection.connection());
                command.ExecuteNonQuery();
                MessageBox.Show("Tüm Ürünler Başarılı Bir Şekilde Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tarihi Geçmiş Tüm Ürünleri Silmek İstediğinize Emin Misiniz? Bu İşlem Geri Alınamaz.", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Delete From Urunler WHERE  Urun_SK_TARIH < GETDATE() or Urun_SK_TARIH = GETDATE()", connection.connection());
                command.ExecuteNonQuery();
                MessageBox.Show("Tarihi Geçmiş Tüm Ürünler Başarılı Bir Şekilde Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
