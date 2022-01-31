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
    public partial class HastaYeniKayit : Form
    {
        public HastaYeniKayit()
        {
            InitializeComponent();
        }
        TextBoxMaxLength txtMaxUzunluk = new TextBoxMaxLength();

        SqlDataReader okuyucu;
        SqlCommand komut;
        int kontrol, IlID, KanGrubuID;

        
        void TCNoKontrol()
        {
            komut = new SqlCommand("prc_HastaTCNoSorgulama", SqlBaglanti.baglanti());

            komut.Parameters.Add("@HastaTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@HastaTCNo"].Value = txtHTCKN.Text;

            komut.CommandType = CommandType.StoredProcedure;

            kontrol = (int)komut.ExecuteScalar();

            SqlBaglanti.baglanti().Close();
        }
        void IlGetir()
        {
            komut = new SqlCommand("prc_prmIller_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                DogduguSehir.Items.Add(okuyucu.GetString(0));
            }

            SqlBaglanti.baglanti().Close();
        }
        void IlIDGetir()
        {
            komut = new SqlCommand("prc_prmIllerID_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@Iller", SqlDbType.NVarChar, 50);
            komut.Parameters["@Iller"].Value = DogduguSehir.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                IlID = Convert.ToInt32(okuyucu.GetInt32(0));
            }

            SqlBaglanti.baglanti().Close();
        }
        void KanGrubuGetir()
        {
            komut = new SqlCommand("prc_prmKanGrubu_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                KanGrubu.Items.Add(okuyucu.GetString(0));
            }

            SqlBaglanti.baglanti().Close();
        }
        void KanGrubuIDGetir()
        {
            komut = new SqlCommand("prc_prmKanGrubuID_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@KanGrubu", SqlDbType.NVarChar, 10);
            komut.Parameters["@KanGrubu"].Value = KanGrubu.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                KanGrubuID = okuyucu.GetInt32(0);
            }

            SqlBaglanti.baglanti().Close();
        }

        private void yeniHastaKayıtButon_Click(object sender, EventArgs e)
        {
            TCNoKontrol();

            if (kontrol == 0)
            {
                if (txtHSifre.Text == txtHTekrarSifre.Text)
                {
                    komut = new SqlCommand("prc_HastaBilgi_Kaydet", SqlBaglanti.baglanti());

                    komut.Parameters.Add("@HastaTCNo", SqlDbType.NVarChar, 11);
                    komut.Parameters["@HastaTCNo"].Value = txtHTCKN.Text;

                    komut.Parameters.Add("@HastaAdi", SqlDbType.NVarChar, 50);
                    komut.Parameters["@HastaAdi"].Value = txtHAd.Text;

                    komut.Parameters.Add("@HastaSoyadi", SqlDbType.NVarChar, 50);
                    komut.Parameters["@HastaSoyadi"].Value = txtHSAd.Text;

                    komut.Parameters.Add("@HastaCinsiyetID", SqlDbType.TinyInt);
                    if (rButonKadın.Checked == true)
                    {
                        komut.Parameters["@HastaCinsiyetID"].Value = 2;
                    }
                    else if (rButonErkek.Checked == true)
                    {
                        komut.Parameters["@HastaCinsiyetID"].Value = 1;
                    }

                    komut.Parameters.Add("@HastaKanGrubuID", SqlDbType.TinyInt);
                    komut.Parameters["@HastaKanGrubuID"].Value = KanGrubuID;

                    komut.Parameters.Add("@HastaEmail", SqlDbType.NVarChar, 50);
                    komut.Parameters["@HastaEmail"].Value = txtHMail.Text;

                    komut.Parameters.Add("@HastaTelefon", SqlDbType.NVarChar, 15);
                    komut.Parameters["@HastaTelefon"].Value = txtHTelefon.Text;

                    komut.Parameters.Add("@HastaSifre", SqlDbType.NVarChar, 30);
                    komut.Parameters["@HastaSifre"].Value = txtHSifre.Text;

                    komut.Parameters.Add("@HastaDogumYeriID", SqlDbType.TinyInt);
                    komut.Parameters["@HastaDogumYeriID"].Value = IlID;

                    komut.Parameters.Add("@HastaDogumTarihi", SqlDbType.NVarChar, 15);
                    komut.Parameters["@HastaDogumTarihi"].Value = txtHDogum.Text;

                    komut.CommandType = CommandType.StoredProcedure;

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hesabınız Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değildir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik numarası veritabanında kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hykCıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DogduguSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlIDGetir();
        }

        private void KanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            KanGrubuIDGetir();
        }

        private void txtHTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxUzunluk.BunifuMetro(txtHTCKN, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HastaYeniKayit_Load(object sender, EventArgs e)
        {
            IlGetir();
            KanGrubuGetir();
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
