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
    public partial class HastaDetayEkran : Form
    {
        public HastaDetayEkran()
        {
            InitializeComponent();
        }
        public string HastaTCNo, HastaAdSoyad;
        public int HastaID;
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;

        static DateTime bugun = DateTime.Today;
        string bugunKisa = bugun.ToShortDateString();

        void HastaRandevuGetir()
        {
            komut = new SqlCommand("prc_Randevular_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@HastaID", SqlDbType.Int);
            komut.Parameters["@HastaID"].Value = HastaID;

            komut.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(komut);

            tablo = new DataTable();

            adapter.Fill(tablo);

            AktifRandevuDataGrid.DataSource = tablo;

            SqlBaglanti.baglanti().Close();

        }

        void HastaGecmisRandevuGetir()
        {
            komut = new SqlCommand("prc_GecmisRandevular_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@HastaID", SqlDbType.Int);
            komut.Parameters["@HastaID"].Value = HastaID;

            komut.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(komut);

            tablo = new DataTable();

            adapter.Fill(tablo);

            bunifuCustomDataGrid1.DataSource = tablo;

            SqlBaglanti.baglanti().Close();

        }
        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniRandevuAlBtn_Click(object sender, EventArgs e)
        {
            RandevuAlmaEkrani randevuEkrani = new RandevuAlmaEkrani();
            randevuEkrani.HastaID = HastaID;
            randevuEkrani.ShowDialog();
        }

        public string tc;

        private void HastaDetayEkran_Load(object sender, EventArgs e)
        {
            lblHastaTC.Text = HastaTCNo;
            lblHastaAdSoyad.Text = HastaAdSoyad;
            HastaRandevuGetir();
            HastaGecmisRandevuGetir();
        }

        private void txtRandevuIptal_Click(object sender, EventArgs e)
        {
            if (sonuc != null)
            {
                komut = new SqlCommand("DELETE FROM Randevular WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
                komut.Parameters.AddWithValue("HastaID", sonuc);

                komut.ExecuteNonQuery();

                MessageBox.Show("Randevunuz Silindi");

                SqlBaglanti.baglanti().Close();

                HastaRandevuGetir();
            }
            else
            {
                MessageBox.Show("Randevunuzu Seçiniz.");
            }
        }
        public object sonuc;
        private void AktifRandevuDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            komut = new SqlCommand("SELECT ID FROM HastaBilgi WHERE HastaTCNo = @HastaTCNo", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@HastaTCNo", AktifRandevuDataGrid.CurrentRow.Cells[0].Value.ToString());

            sonuc = komut.ExecuteScalar();

            SqlBaglanti.baglanti().Close();
        }

        private void bilgileriniGuncelle_Click(object sender, EventArgs e)
        {
            HastaBilgiGuncelle hBilgiGuncelle = new HastaBilgiGuncelle();
            hBilgiGuncelle.HastaTCNo = HastaTCNo;

            hBilgiGuncelle.ShowDialog();
        }
    }
}
