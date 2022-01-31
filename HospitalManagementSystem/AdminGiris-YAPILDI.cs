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

namespace HospitalManagementSystem
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        TextBoxMaxLength txtMaxUzunluk = new TextBoxMaxLength();

        SqlCommand komut;
        SqlDataReader okuyucu;
        string AdminTCNo, AdminSifre;

        void AdminBilgileriniGetir()
        {
            komut = new SqlCommand("prc_Admin_Getir", SqlBaglanti.baglanti());
            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                AdminTCNo = okuyucu.GetString(0);
                AdminSifre = okuyucu.GetString(1);
            }

            SqlBaglanti.baglanti().Close();
        }

        private void doktorGirisButon_Click(object sender, EventArgs e)
        {
            AdminBilgileriniGetir();

            if (txtAdminTCNo.Text == AdminTCNo && txtAdminSifre.Text == AdminSifre)
            {
                MessageBox.Show("Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminEkran adminEkran = new AdminEkran();
                adminEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış! Kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlBaglanti.baglanti().Close();
        }
        private void txtAdminTCNo_Click(object sender, EventArgs e)
        {
            txtAdminTCNo.Text = null;
        }
        private void txtAdminSifre_Click(object sender, EventArgs e)
        {
            txtAdminSifre.Text = null;
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void txtAdminTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxUzunluk.BunifuMetro(txtAdminTCNo, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
