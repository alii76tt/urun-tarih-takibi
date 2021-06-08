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

    public partial class Giris : MetroFramework.Forms.MetroForm
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        Ana_Form ana_Form = new Ana_Form();
        Tarih_Kontrol_Bildirim tarih_Kontrol_Bildirim = new Tarih_Kontrol_Bildirim();
        Sql_Connection connection = new Sql_Connection();


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *From Kullanıcılar Where username = @user And password = @pass", connection.connection());
            command.Parameters.AddWithValue("@user", usernameTextbox.Text);
            command.Parameters.AddWithValue("@pass", passwordTextbox.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                ana_Form.veri = usernameTextbox.Text;
                ana_Form.Show();
                this.Hide();
                tarih_Kontrol_Bildirim.Show();
            }
            else if (passwordTextbox.Text == String.Empty)
            {
                MessageBox.Show("Lütfen Şifreyi Girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifre Veya Kullanıcı Adı Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand("Select *From Kullanıcılar Where username = @user And password = @pass", connection.connection());
                command.Parameters.AddWithValue("@user", usernameTextbox.Text);
                command.Parameters.AddWithValue("@pass", passwordTextbox.Text);
                SqlDataReader dr = command.ExecuteReader();
                if (e.KeyCode == Keys.Enter)
                {
                    if (dr.Read())
                    {
                        ana_Form.veri = usernameTextbox.Text;
                        ana_Form.Show();
                        this.Hide();
                        tarih_Kontrol_Bildirim.Show();
                    }
                    else if (passwordTextbox.Text == String.Empty)
                    {
                        MessageBox.Show("Lütfen Şifreyi Girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Şifre Veya Kullanıcı Adı Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }
    }
}
