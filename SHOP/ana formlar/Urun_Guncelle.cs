using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SHOP
{
    public partial class Urun_Guncelle : MetroFramework.Forms.MetroForm
    {
        public Urun_Guncelle()
        {
            InitializeComponent();
        }

        Ana_Form ana_Form = new Ana_Form();
        Sql_Connection connection = new Sql_Connection();

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunbarkodtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            urunisimtextbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            uruncesidComboBox.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            uretimtarihiDatepicker.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            tuketimDatepicker.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select *From Urunler Where Urun_Barkod='" + urunbarkodtextbox.Text + "'", connection.connection());
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
            catch (Exception)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.urunlerTableAdapter1.FillBy(this.urun_Tarih_TakibiDataSet2.Urunler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (urunbarkodtextbox.Text==string.Empty && urunisimtextbox.Text==string.Empty)
            {
               MessageBox.Show("Lütfen Güncellenecek Ürünü Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Update Urunler Set Urun_BARKOD=@p1,Urun_ISIM=@p2,Urun_CESIDI=@p3,Urun_TK_TARIH=@p4,Urun_SK_TARIH=@p5 Where Urun_BARKOD=@p1", connection.connection());
                    command.Parameters.AddWithValue("@p1", urunbarkodtextbox.Text);
                    command.Parameters.AddWithValue("@p2", urunisimtextbox.Text.ToString());
                    command.Parameters.AddWithValue("@p3", uruncesidComboBox.Text.ToString());
                    command.Parameters.AddWithValue("@p4", uretimtarihiDatepicker.Value);
                    command.Parameters.AddWithValue("@p5", tuketimDatepicker.Value);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ürün Güncelleme Yapılamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
