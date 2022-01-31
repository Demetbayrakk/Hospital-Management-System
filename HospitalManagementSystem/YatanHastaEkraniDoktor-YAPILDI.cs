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
    public partial class YatanHastaEkraniDoktor : Form
    {
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;
        SqlDataReader okuyucu;

        DateTime bugun = DateTime.Now;

        public string YatisTarihi;
        public int DoktorID, HastaID, PoliklinikID;

        public YatanHastaEkraniDoktor()
        {
            InitializeComponent();
        }
        void YatanHastaGetir()
        {
            komut = new SqlCommand("prc_YatanHastaTaburcu", SqlBaglanti.baglanti());
            komut.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(komut);

            tablo = new DataTable();

            adapter.Fill(tablo);

            dataGridView1.DataSource = tablo;
        }
        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taburcuEtButon_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("INSERT INTO TaburcuOlanHastalar VALUES(@HastaID, @DoktorID, @PoliklinikID, @YatisTarihi, @TaburcuTarihi)", SqlBaglanti.baglanti());

            komut.Parameters.AddWithValue("HastaID", HastaID);
            komut.Parameters.AddWithValue("DoktorID", DoktorID);
            komut.Parameters.AddWithValue("PoliklinikID", PoliklinikID);
            komut.Parameters.AddWithValue("YatisTarihi", YatisTarihi);
            komut.Parameters.AddWithValue("TaburcuTarihi", bugun.ToShortDateString().ToString());

            komut.ExecuteNonQuery();

            MessageBox.Show("Hasta Taburcu Edildi.");

            komut = new SqlCommand("DELETE FROM YatanHastalar WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("HastaID", HastaID);
            komut.ExecuteNonQuery();

            YatanHastaGetir();

            SqlBaglanti.baglanti().Close();
        }

        private void YatanHastaEkraniDoktor_Load(object sender, EventArgs e)
        {
            YatanHastaGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            komut = new SqlCommand("SELECT ID FROM HastaBilgi WHERE HastaTCNo = @HastaTCNo", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@HastaTCNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var sonuc = komut.ExecuteScalar();

            komut = new SqlCommand("SELECT HastaID, DoktorID, KlinikID, YatisTarihi FROM YatanHastalar WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@HastaID", sonuc);

            okuyucu = komut.ExecuteReader();
                
            while (okuyucu.Read())
            {
                HastaID = okuyucu.GetInt32(0);
                DoktorID = okuyucu.GetInt32(1);
                PoliklinikID = okuyucu.GetInt32(2);
                YatisTarihi = okuyucu.GetString(3);
            }
        }
    }
}
