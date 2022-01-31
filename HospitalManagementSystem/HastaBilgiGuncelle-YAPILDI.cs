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
    public partial class HastaBilgiGuncelle : Form
    {
        public HastaBilgiGuncelle()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataReader okuyucu;
        int IlID, KanGrubuID, HastaID;

        public string HastaTCNo;

        void IlGetir()
        {
            komut = new SqlCommand("prc_prmIller_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;
            
            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                DogduguSehir.Items.Add(okuyucu.GetString(0));
            }
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
        }
        void KanGrubuGetir()
        {
            komut = new SqlCommand("prc_prmKanGrubu_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                cmbKanGrubu.Items.Add(okuyucu.GetString(0));
            }

        }
        void KanGrubuIDGetir()
        {
            komut = new SqlCommand("prc_prmKanGrubuID_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@KanGrubu", SqlDbType.NVarChar, 20);
            komut.Parameters["@KanGrubu"].Value = cmbKanGrubu.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                KanGrubuID = Convert.ToInt32(okuyucu.GetInt32(0));
            }
        }
        void TCYeGoreHastaGetir()
        {
            komut = new SqlCommand("prc_HastaTumBilgi_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@HastaTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@HastaTCNo"].Value = txtHTCKN.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                HastaID = (int)okuyucu.GetInt32(0);
                txtHAd.Text = okuyucu.GetString(2);
                txtHSAd.Text = okuyucu.GetString(3);
                if (okuyucu.GetString(4) == "Erkek")
                {
                    rButonErkek.Checked = true;
                }
                else if (okuyucu.GetString(4) == "Kadın")
                {
                    rButonKadın.Checked = true;
                }
                cmbKanGrubu.Text = okuyucu.GetString(5);
                txtHMail.Text = okuyucu.GetString(6);
                maskedTextBox2.Text = okuyucu.GetString(7);
                txtSifre.Text = okuyucu.GetString(8);
                DogduguSehir.Text = okuyucu.GetString(9);
                maskedTextBox1.Text = okuyucu.GetString(10);
            }

            SqlBaglanti.baglanti().Close();
        }
        
        private void hykCıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bilgilerimiGuncelleButon_Click(object sender, EventArgs e)
        {
            IlIDGetir();
            KanGrubuIDGetir();

            komut = new SqlCommand("prc_HastaBilgi_Guncelle", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add("@HastaID", SqlDbType.Int);
            komut.Parameters["@HastaID"].Value = HastaID;

            komut.Parameters.Add("@HastaTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@HastaTCNo"].Value = txtHTCKN.Text;

            komut.Parameters.Add("@HastaAdi", SqlDbType.NVarChar, 50);
            komut.Parameters["@HastaAdi"].Value = txtHAd.Text;

            komut.Parameters.Add("@HastaSoyadi", SqlDbType.NVarChar, 50);
            komut.Parameters["@HastaSoyadi"].Value = txtHSAd.Text;

            komut.Parameters.Add("@HastaCinsiyetID", SqlDbType.Int);

            if (rButonErkek.Checked == true)
            {
                komut.Parameters["@HastaCinsiyetID"].Value = 1;
            }
            else if (rButonKadın.Checked == true)
            {
                komut.Parameters["@HastaCinsiyetID"].Value = 2;
            }
            
            komut.Parameters.Add("@HastaKanGrubuID", SqlDbType.Int);
            komut.Parameters["@HastaKanGrubuID"].Value = KanGrubuID;

            komut.Parameters.Add("@HastaEmail", SqlDbType.NVarChar, 50);
            komut.Parameters["@HastaEmail"].Value = txtHMail.Text;

            komut.Parameters.Add("@HastaTelefon", SqlDbType.NVarChar, 15);
            komut.Parameters["@HastaTelefon"].Value = maskedTextBox2.Text;

            komut.Parameters.Add("@HastaSifre", SqlDbType.NVarChar, 30);
            komut.Parameters["@HastaSifre"].Value = txtSifre.Text;

            komut.Parameters.Add("@HastaDogumYeriID", SqlDbType.Int);
            komut.Parameters["@HastaDogumYeriID"].Value = IlID;

            komut.Parameters.Add("@HastaDogumTarihi", SqlDbType.NVarChar, 15);
            komut.Parameters["@HastaDogumTarihi"].Value = maskedTextBox1.Text;

            komut.ExecuteNonQuery();

            MessageBox.Show("Güncellendi.");

            SqlBaglanti.baglanti().Close();

            TCYeGoreHastaGetir();
        }

        private void HastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            txtHTCKN.Text = HastaTCNo;
            IlGetir();

            KanGrubuGetir();
            
            TCYeGoreHastaGetir();
        }

        private void KanGrubu_SelectedValueChanged(object sender, EventArgs e)
        {
        }


        private void DogduguSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DogduguSehir_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        TextBoxMaxLength txtMaxLength = new TextBoxMaxLength();
        private void txtHTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxLength.BunifuMetro(txtHTCKN, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHTCKN_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
