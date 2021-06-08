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
    public partial class Urunler : MetroFramework.Forms.MetroForm
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        Sql_Connection connection = new Sql_Connection();

        public void urunlergetir()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ana_Form ana_Form = new Ana_Form();
            this.Hide();
            ana_Form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            urunlergetir();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select *From Urunler Where Urun_Barkod='" + urunbarkodtxt.Text + "'", connection.connection());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunbarkodtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            urunbarkodtxt.Text = "";
        }
    }
}
