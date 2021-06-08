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
    public partial class Kullanıcı_Ekle : Form
    {
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }

        Sql_Connection connection = new Sql_Connection();

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (kullanıcıadıtext.Text == string.Empty && sifretext.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kullanıcı Bilgilerini Girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("insert into Kullanıcılar (username,isim,password,yetki) values(@p1,@p2,@p3,@p4)", connection.connection());
                    command.Parameters.AddWithValue("@p1", kullanıcıadıtext.Text);
                    command.Parameters.AddWithValue("@p2", isimtext.Text);
                    command.Parameters.AddWithValue("@p3", sifretext.Text);
                    command.Parameters.AddWithValue("@p4", this.yetkicheckBox.CheckState);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı Kaydı Yapılamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
