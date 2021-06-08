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
    public partial class Kullanıcı_Duzenle : Form
    {
        public Kullanıcı_Duzenle()
        {
            InitializeComponent();
        }

        Sql_Connection connect = new Sql_Connection();

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (kullanıcıadıtext.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Güncellenecek Kullanıcı İsimini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlCommand command = new SqlCommand("Select *From Kullanıcılar Where username='" + kullanıcıadıtext.Text + "'", connect.connection());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    kullanıcıadıtext.Text = sqlDataReader["username"].ToString();
                    isimtext.Text = sqlDataReader["isim"].ToString();
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
                MessageBox.Show("Kullanıcı Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }    
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (isimtext.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Güncellenecek Kullanıcı İsimini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Update Kullanıcılar Set isim=@p1, username=@p2, password=@p3, yetki=@p4 Where isim=@p1", connect.connection());
                    command.Parameters.AddWithValue("@p1", isimtext.Text);
                    command.Parameters.AddWithValue("@p2", kullanıcıadıtext.Text);
                    command.Parameters.AddWithValue("@p3", sifretext.Text);
                    command.Parameters.AddWithValue("@p4", (int)yetkicheckBox.CheckState);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı Güncellenemedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                    
            }
        }
    }
}
