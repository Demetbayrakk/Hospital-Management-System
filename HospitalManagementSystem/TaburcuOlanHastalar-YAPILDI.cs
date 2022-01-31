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
    public partial class TaburcuOlanHastalar : Form
    {
        public TaburcuOlanHastalar()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;

        int hastaID, doktorID, poliklinikID, fiyat = 50;
        double gunFarki;
        //DateTime yatisTarihi, taburcuTarihi
        string yatisTarihi, taburcuTarihi;
        //string kisaYatisTarihi, kisaTaburcuTarihi;
        void TaburcuOlanHastalarGetir()
        {
            komut = new SqlCommand("prc_TaburcuFiyat", SqlBaglanti.baglanti());
            komut.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(komut);
            tablo = new DataTable();

            adapter.Fill(tablo);

            bunifuCustomDataGrid1.DataSource = tablo;

            bunifuCustomDataGrid1.Columns[0].Visible = false;
            bunifuCustomDataGrid1.Columns[7].Visible = false;
            bunifuCustomDataGrid1.Columns[8].Visible = false;
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitirButon_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("INSERT INTO TaburcuOlmusHastalar VALUES(@HastaID, @DoktorID, @PoliklinikID, @YatisTarihi, @TaburcuTarihi, @Fiyat)", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("HastaID", hastaID);
            komut.Parameters.AddWithValue("DoktorID", doktorID);
            komut.Parameters.AddWithValue("PoliklinikID", poliklinikID);
            komut.Parameters.AddWithValue("YatisTarihi", yatisTarihi);
            komut.Parameters.AddWithValue("TaburcuTarihi", taburcuTarihi);
            komut.Parameters.AddWithValue("Fiyat", UcretBilgisi.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("Hasta Taburcu İşlemi Tamamlandı");

            komut = new SqlCommand("DELETE FROM TaburcuOlanHastalar WHERE HastaID = @HastaID", SqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("HastaID", hastaID);

            komut.ExecuteNonQuery();

            TaburcuOlanHastalarGetir();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            hastaID = (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value;
            yatisTarihi = (string)bunifuCustomDataGrid1.CurrentRow.Cells[5].Value;
            taburcuTarihi = (string)bunifuCustomDataGrid1.CurrentRow.Cells[6].Value;
            doktorID = (int)bunifuCustomDataGrid1.CurrentRow.Cells[7].Value;
            poliklinikID = (int)bunifuCustomDataGrid1.CurrentRow.Cells[8].Value;

            gunFarki = (int)(Convert.ToDateTime(taburcuTarihi) - Convert.ToDateTime(yatisTarihi)).TotalDays;

            if (gunFarki == 0)
            {
                gunFarki = 1;
                fiyat *= (int)gunFarki;
                UcretBilgisi.Text = fiyat.ToString() + " TL";
                fiyat = 50;
            }
            else if (gunFarki > 0)
            {
                fiyat *= (int)gunFarki;
                UcretBilgisi.Text = fiyat.ToString() + " TL";
                fiyat = 50;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaburcuOlanHastalar_Load(object sender, EventArgs e)
        {
            TaburcuOlanHastalarGetir();
        }
    }
}
