using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP
{
    public partial class Ayarlar : MetroFramework.Forms.MetroForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            panelkullanıcılarSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelkullanıcılarSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Kullanıcı_Ekle());
            hideSubMenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Kullanıc_Sil());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Kullanıcı_Duzenle());
            hideSubMenu();
        }

        private void backBox_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/alii76tt");
        }
    }
}
