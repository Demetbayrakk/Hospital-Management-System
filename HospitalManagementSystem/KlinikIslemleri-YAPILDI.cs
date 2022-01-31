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
    public partial class KlinikIslemleri : Form
    {
        public KlinikIslemleri()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        void DataGridBilgiGetir()
        {
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            SqlCommand komut = new SqlCommand("prc_prmPoliklinik_Getir", SqlBaglanti.baglanti());
            komut.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(komut);
            ds = new DataSet();

            da.Fill(ds, "PoliklinikAdi");
            bunifuCustomDataGrid1.DataSource = ds.Tables["PoliklinikAdi"];
        }
        private void KlinikIslemleri_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            DataGridBilgiGetir();
        }

        private void klinikCıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoktorAd.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoktorAd.Text) || string.IsNullOrWhiteSpace(txtDoktorAd.Text))
            {
                MessageBox.Show("Ekleme yapınız.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("prc_prmPoliklinik_Kaydet", SqlBaglanti.baglanti());
                komut.CommandType = CommandType.StoredProcedure;


                komut.Parameters.Add("@PoliklinikAdi", SqlDbType.NVarChar, 100);
                komut.Parameters["@PoliklinikAdi"].Value = txtDoktorAd.Text;


                komut.ExecuteNonQuery();
                MessageBox.Show("Eklendi.");
                SqlBaglanti.baglanti().Close();
                txtDoktorAd.Text = "";
                DataGridBilgiGetir();
            }

        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoktorAd.Text) || string.IsNullOrWhiteSpace(txtDoktorAd.Text))
            {
                MessageBox.Show("Ekleme yapınız.");
            }
            else
            {
                string degersecilen = bunifuCustomDataGrid1.CurrentRow.Cells["PoliklinikAdi"].Value.ToString();

                SqlCommand komut = new SqlCommand("prc_prmPoliklinik_Sil", SqlBaglanti.baglanti());
                komut.CommandType = CommandType.StoredProcedure;


                komut.Parameters.Add("@PoliklinikAdi", SqlDbType.NVarChar, 100);
                komut.Parameters["@PoliklinikAdi"].Value = degersecilen;
                komut.ExecuteNonQuery();

                MessageBox.Show("Silindi.");
                txtDoktorAd.Text = "";
                SqlBaglanti.baglanti().Close();

                DataGridBilgiGetir();
            }

        }

        private void düzenleButon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoktorAd.Text) || string.IsNullOrWhiteSpace(txtDoktorAd.Text))
            {
                MessageBox.Show("Ekleme yapınız.");

            }
            else
            {
                string degersecilen = bunifuCustomDataGrid1.CurrentRow.Cells["PoliklinikAdi"].Value.ToString();

                SqlCommand komut = new SqlCommand("prc_prmPoliklinik_Guncelle", SqlBaglanti.baglanti());
                komut.CommandType = CommandType.StoredProcedure;


                komut.Parameters.Add("@PoliklinikAdi", SqlDbType.NVarChar, 100);
                komut.Parameters["@PoliklinikAdi"].Value = txtDoktorAd.Text;
                komut.Parameters.Add("@PoliklinikAdi2", SqlDbType.NVarChar, 100);
                komut.Parameters["@PoliklinikAdi2"].Value = degersecilen;

                komut.ExecuteNonQuery();
                MessageBox.Show("Güncellendi.");
                SqlBaglanti.baglanti().Close();
                txtDoktorAd.Text = "";
                DataGridBilgiGetir();
            }
        }
    }
}
