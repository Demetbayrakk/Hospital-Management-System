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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        TextBoxMaxLength txtMaxUzunluk = new TextBoxMaxLength();

        SqlDataReader okuyucu;
        SqlCommand komut;
        public string DoktorTCNo, DoktorSifre, DoktorUnvanAdSoyad, DoktorPoliklinik;
        public int DoktorID;
        void DoktorGetir()
        {
            komut = new SqlCommand("prc_DoktorBilgi_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@DoktorTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@DoktorTCNo"].Value = bunifuMetroTextbox1.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                DoktorID = okuyucu.GetInt32(0);
                DoktorUnvanAdSoyad = okuyucu.GetString(1) + okuyucu.GetString(2) + " " + okuyucu.GetString(3);
                DoktorPoliklinik = okuyucu.GetString(4);
                DoktorTCNo = okuyucu.GetString(5);
                DoktorSifre = okuyucu.GetString(6);
            }

            SqlBaglanti.baglanti().Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doktorGirisButon_Click(object sender, EventArgs e)
        {
            DoktorGetir();
            if (bunifuMetroTextbox1.Text == DoktorTCNo && bunifuMetroTextbox2.Text == DoktorSifre)
            {
                MessageBox.Show("Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DoktorEkrani doktorEkrani = new DoktorEkrani();

                doktorEkrani.DoktorUnvanAdSoyad = DoktorUnvanAdSoyad;
                doktorEkrani.DoktorPoliklinik = DoktorPoliklinik;
                doktorEkrani.DoktorID = DoktorID;

                doktorEkrani.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış! Kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxUzunluk.BunifuMetro(bunifuMetroTextbox1, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
        }
    }
}
