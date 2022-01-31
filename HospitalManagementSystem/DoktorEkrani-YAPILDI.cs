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
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;
        SqlDataReader okuyucu;

        DateTime bugun = DateTime.Now;

        public string DoktorUnvanAdSoyad, DoktorPoliklinik, RandevuTarihi, RandevuSaati;
        public int DoktorID, HastaID, PoliklinikID;

        public void HastaGetir()
        {
            komut = new SqlCommand("prc_DoktorRandevu_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@DoktorID", SqlDbType.Int);
            komut.Parameters["@DoktorID"].Value = DoktorID;

            komut.Parameters.Add("@RandevuTarihi", SqlDbType.NVarChar, 20);
            komut.Parameters["@RandevuTarihi"].Value = bugun.ToShortDateString().ToString();

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

        private void yatanHastaGoster_Click(object sender, EventArgs e)
        {
            YatanHastaEkraniDoktor yHastaEkraniDoktor = new YatanHastaEkraniDoktor();
            yHastaEkraniDoktor.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoktorEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoktorGiris doktorGiris = new DoktorGiris();
            doktorGiris.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            komut = new SqlCommand("SELECT ID FROM HastaBilgi WHERE HastaTCNo = @HastaTCNo", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@HastaTCNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var sonuc = komut.ExecuteScalar();

            komut = new SqlCommand("SELECT HastaID, DoktorID, PoliklinikID, RandevuTarihi, RandevuSaati FROM Randevular WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@HastaID", sonuc);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                HastaID = okuyucu.GetInt32(0);
                DoktorID = okuyucu.GetInt32(1);
                PoliklinikID = okuyucu.GetInt32(2);
                RandevuTarihi = okuyucu.GetString(3);
                RandevuSaati = okuyucu.GetString(4);
            }

            //MessageBox.Show(HastaID.ToString() + " " + DoktorID.ToString() + " " + PoliklinikID.ToString() + " " + RandevuTarihi.ToString() + " " + RandevuSaati.ToString()) ;
        }
        void HastaSil()
        {
            komut = new SqlCommand("DELETE FROM Randevular WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("HastaID", HastaID);

            komut.ExecuteNonQuery();

            SqlBaglanti.baglanti().Close();
        }
        private void secileniAktar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                komut = new SqlCommand("INSERT INTO GecmisRandevular VALUES(@HastaID, @DoktorID, @KlinikID, @RandevuTarihi, @RandevuSaati)", SqlBaglanti.baglanti());
                komut.Parameters.AddWithValue("HastaID", HastaID);
                komut.Parameters.AddWithValue("DoktorID", DoktorID);
                komut.Parameters.AddWithValue("KlinikID", PoliklinikID);
                komut.Parameters.AddWithValue("RandevuTarihi", RandevuTarihi);
                komut.Parameters.AddWithValue("RandevuSaati", RandevuSaati);

                komut.ExecuteNonQuery();

                MessageBox.Show("Hastanın İşlemi Bitti.");

                HastaSil();

                HastaGetir();

                comboBox1.Text = null;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                komut = new SqlCommand("INSERT INTO YatanHastalar VALUES(@HastaID, @DoktorID, @KlinikID, @YatisTarihi)", SqlBaglanti.baglanti());
                komut.Parameters.AddWithValue("HastaID", HastaID);
                komut.Parameters.AddWithValue("DoktorID", DoktorID);
                komut.Parameters.AddWithValue("KlinikID", PoliklinikID);
                komut.Parameters.AddWithValue("YatisTarihi", bugun.ToShortDateString().ToString());

                komut.ExecuteNonQuery();

                MessageBox.Show("Hasta Yatırıldı.");

                HastaSil();

                HastaGetir();
                secileniAktar.Enabled = false;
                comboBox1.Text = null;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.Text != null)
                {
                    komut = new SqlCommand("INSERT INTO NakilIslemleri VALUES(@HastaID, @PoliklinikID,  @DoktorID, @NakilYeri, @NakilTarihi)", SqlBaglanti.baglanti());

                    komut.Parameters.AddWithValue("HastaID", HastaID);
                    komut.Parameters.AddWithValue("PoliklinikID", PoliklinikID);
                    komut.Parameters.AddWithValue("DoktorID", DoktorID);
                    komut.Parameters.AddWithValue("NakilYeri", comboBox2.Text);
                    komut.Parameters.AddWithValue("NakilTarihi", bugun.ToShortDateString().ToString());

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hasta Nakil edildi.");
                    HastaSil();
                    HastaGetir();
                    secileniAktar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Nakil olacak hastaneyi seçiniz.");
                }
                
            }
            else
            {
                MessageBox.Show("Seçiniz.");
            }
        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            label1.Text = DoktorUnvanAdSoyad;
            label2.Text = DoktorPoliklinik;

            HastaGetir();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
    }
}
