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
    public partial class Kullanıc_Sil : Form
    {
        public Kullanıc_Sil()
        {
            InitializeComponent();
        }

        Sql_Connection connection = new Sql_Connection();

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (kullanıcıadıtext.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Silinecek Kullanıcı İsmini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Delete From Kullanıcılar Where username=@p1", connection.connection());
                    command.Parameters.AddWithValue("@p1", kullanıcıadıtext.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı Silinemedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (kullanıcıadıtext.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Güncellenecek Kullanıcı İsimini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlCommand command = new SqlCommand("Select *From Kullanıcılar Where username='" + kullanıcıadıtext.Text + "'", connection.connection());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    kullanıcıadıtext.Text = sqlDataReader["username"].ToString();
                    kullanıcisimtext.Text = sqlDataReader["isim"].ToString();
                    sifretext.Text = sqlDataReader["password"].ToString();
                    if (sqlDataReader["yetki"].ToString() == "True")
                    {
                        yetkitext.Text = "Yetkili Kullanıcı";
                    }
                    else
                    {
                        yetkitext.Text = "Yetkisiz Kullanıcı";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
