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
    public partial class Trih_Kontrol_Form : MetroFramework.Forms.MetroForm
    {
        public Trih_Kontrol_Form()
        {
            InitializeComponent();
        }

        Ana_Form ana_Form = new Ana_Form();
        Sql_Connection connection = new Sql_Connection();
        DataGridViewCellStyle rowColor = new DataGridViewCellStyle();

        private void Trih_Kontrol_Form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;       
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from Urunler Where Urun_BARKOD=@p1 and Urun_SK_TARIH<GETDATE() or Urun_SK_TARIH=GETDATE()", connection.connection());
                command.Parameters.AddWithValue("@p1", urunbarkodtext.Text);
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
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_Form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From Urunler Where Urun_SK_TARIH<GETDATE() or Urun_SK_TARIH=GETDATE()", connection.connection());
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
                if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) < Convert.ToDateTime(DateTime.Today) || Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) == Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.Red;
                }
                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunbarkodtext.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
