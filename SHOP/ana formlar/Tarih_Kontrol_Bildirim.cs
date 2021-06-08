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
     public partial class Tarih_Kontrol_Bildirim : MetroFramework.Forms.MetroForm
    {

        public Tarih_Kontrol_Bildirim()
        {
            InitializeComponent();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tarih_Kontrol_Bildirim_Load(object sender, EventArgs e)
        {
            // Bildirim penceresi gibi (sağ alt köşede) gözükmesi için
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            Sql_Connection connection = new Sql_Connection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler Where Urun_SK_TARIH<GETDATE() or Urun_SK_TARIH=GETDATE()", connection.connection());
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
                Application.DoEvents();
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();

                if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) < Convert.ToDateTime(DateTime.Today) || Convert.ToDateTime(dataGridView1.Rows[i].Cells["Urun_SK_TARIH"].Value) == Convert.ToDateTime(DateTime.Today))
                {
                    rowColor.BackColor = Color.Red;
                }
                dataGridView1.Rows[i].DefaultCellStyle = rowColor;
            }

        }
    }
}
