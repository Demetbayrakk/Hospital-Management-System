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
    public partial class DoktorIslemleri : Form
    {
        public DoktorIslemleri()
        {
            InitializeComponent();
        }

        TextBoxMaxLength txtMaxLength = new TextBoxMaxLength();

        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;
        SqlDataReader okuyucu;

        int kontrol, poliklinikID, DoktorID;
        void PoliklinikID()
        {
            komut = new SqlCommand("prc_PoliklinikID_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@PoliklinikAdi", SqlDbType.NVarChar, 100);
            komut.Parameters["@PoliklinikAdi"].Value = cmbKlinik.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                poliklinikID = okuyucu.GetInt32(0);
            }

            SqlBaglanti.baglanti().Close();
            okuyucu.Close();
        }
        void Poliklinik()
        {

            komut = new SqlCommand("prc_prmPoliklinik_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                cmbKlinik.Items.Add(okuyucu.GetString(1));
            }

            SqlBaglanti.baglanti().Close();
        }
        void TCNoKontrol()
        {
            komut = new SqlCommand("prc_DoktorTCNoSorgulama", SqlBaglanti.baglanti());

            komut.Parameters.Add("@DoktorTCNo", SqlDbType.NVarChar, 11);
            komut.Parameters["@DoktorTCNo"].Value = txtDoktorTC.Text;

            komut.CommandType = CommandType.StoredProcedure;

            kontrol = (int)komut.ExecuteScalar();

            SqlBaglanti.baglanti().Close();
        }
        void DoktorGetir()
        {
            komut = new SqlCommand("prc_DoktorTumBilgileri_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(komut);

            tablo = new DataTable();

            adapter.Fill(tablo);

            bunifuCustomDataGrid1.DataSource = tablo;
            
            SqlBaglanti.baglanti().Close();
        }

        private void DoktorIslemleri_Load(object sender, EventArgs e)
        {
            Poliklinik();
            DoktorGetir();
        }

        private void doktorIslemCıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            TCNoKontrol();

            if (kontrol == 0)
            {
                komut = new SqlCommand("prc_DoktorBilgi_Kaydet", SqlBaglanti.baglanti());
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.Add("@DoktorTCNo", SqlDbType.NVarChar, 11);
                komut.Parameters["@DoktorTCNo"].Value = txtDoktorTC.Text;

                komut.Parameters.Add("@DoktorUnvan", SqlDbType.NVarChar, 20);
                komut.Parameters["@DoktorUnvan"].Value = txtDoktorAd.Text;

                komut.Parameters.Add("@DoktorAdi", SqlDbType.NVarChar, 50);
                komut.Parameters["@DoktorAdi"].Value = txtDoktorSoyad.Text;

                komut.Parameters.Add("@DoktorSoyadi", SqlDbType.NVarChar, 50);
                komut.Parameters["@DoktorSoyadi"].Value = txtDoktorSoyad.Text;

                komut.Parameters.Add("@DoktorTelefon", SqlDbType.NVarChar, 20);
                komut.Parameters["@DoktorTelefon"].Value = mtxtDoktorTelefon.Text;

                komut.Parameters.Add("@DoktorSifre", SqlDbType.NVarChar, 50);
                komut.Parameters["@DoktorSifre"].Value = txtDoktorSifre.Text;

                komut.Parameters.Add("@DoktorKlinikID", SqlDbType.TinyInt);
                komut.Parameters["@DoktorKlinikID"].Value = poliklinikID;

                komut.ExecuteNonQuery();

                SqlBaglanti.baglanti().Close();

                MessageBox.Show("Hesabınız Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DoktorGetir();
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik numarası veritabanında kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoktorTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxLength.BunifuMetro(txtDoktorTC, 11);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoliklinikID();
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("prc_DoktorBilgi_Sil", SqlBaglanti.baglanti());
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add("@DoktorID", SqlDbType.Int);
            komut.Parameters["@DoktorID"].Value = DoktorID;

            komut.ExecuteNonQuery();

            MessageBox.Show("Hesabınız Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlBaglanti.baglanti().Close();

            DoktorGetir();
        }

        private void düzenleButon_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("prc_DoktorBilgi_Guncelle", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            //komut.Parameters.Add("@DoktorTCNo", SqlDbType.NVarChar, 11);
            //komut.Parameters["@DoktorTCNo"].Value = txtDoktorTC.Text;

            komut.Parameters.Add("@DoktorUnvan", SqlDbType.NVarChar, 20);
            komut.Parameters["@DoktorUnvan"].Value = txtDoktorUnvan.Text;

            komut.Parameters.Add("@DoktorAdi", SqlDbType.NVarChar, 50);
            komut.Parameters["@DoktorAdi"].Value = txtDoktorAd.Text;

            komut.Parameters.Add("@DoktorSoyadi", SqlDbType.NVarChar, 50);
            komut.Parameters["@DoktorSoyadi"].Value = txtDoktorSoyad.Text;

            komut.Parameters.Add("@DoktorTelefon", SqlDbType.NVarChar, 20);
            komut.Parameters["@DoktorTelefon"].Value = mtxtDoktorTelefon.Text;

            komut.Parameters.Add("@DoktorSifre", SqlDbType.NVarChar, 50);
            komut.Parameters["@DoktorSifre"].Value = txtDoktorSifre.Text;

            komut.Parameters.Add("@DoktorKlinikID", SqlDbType.Int);
            komut.Parameters["@DoktorKlinikID"].Value = poliklinikID;

            komut.Parameters.Add("@DoktorID", SqlDbType.Int);
            komut.Parameters["@DoktorID"].Value = DoktorID;

            komut.ExecuteNonQuery();

            SqlBaglanti.baglanti().Close();

            MessageBox.Show("Hesabınız Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoktorGetir();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoktorID = (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value;
            txtDoktorTC.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            cmbKlinik.SelectedItem = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            txtDoktorUnvan.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            txtDoktorAd.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            txtDoktorSoyad.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            mtxtDoktorTelefon.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
            txtDoktorSifre.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
