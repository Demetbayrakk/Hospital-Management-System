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
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataReader okuyucu;
        TextBoxMaxLength txtMaxLength = new TextBoxMaxLength();

        public string HastaTCNo, HastaSifre, HastaAdiSoyadi;
        public int HastaID;
        void HastaBilgileriniGetir()
        {
            komut = new SqlCommand("prc_HastaBilgi_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@HastaTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@HastaTCNo"].Value = txtHastaTCNo.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                HastaID = (int)okuyucu.GetInt32(0);
                HastaTCNo = okuyucu.GetString(1);
                HastaSifre = okuyucu.GetString(2);
                HastaAdiSoyadi = okuyucu.GetString(3) + " " + okuyucu.GetString(4);
            }
        }
        
        private void hastaGirisYapButon_Click(object sender, EventArgs e)
        {
            HastaBilgileriniGetir();

            if (txtHastaTCNo.Text == HastaTCNo && txtHastaSifre.Text == HastaSifre)
            {
                MessageBox.Show("Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HastaDetayEkran hastaDetayEkran = new HastaDetayEkran();

                hastaDetayEkran.HastaTCNo = HastaTCNo;
                hastaDetayEkran.HastaAdSoyad = HastaAdiSoyadi;
                hastaDetayEkran.HastaID = HastaID;

                hastaDetayEkran.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış! Kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlBaglanti.baglanti().Close();
        }

        private void txtHastaTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxLength.BunifuMetro(txtHastaTCNo, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hastaYeniHesapButon_Click(object sender, EventArgs e)
        {
            HastaYeniKayit hYeniKayit = new HastaYeniKayit();
            hYeniKayit.Show();
        }
    }
}
