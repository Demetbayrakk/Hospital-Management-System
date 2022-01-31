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
    public partial class RandevuAlmaEkrani : Form
    {
        public RandevuAlmaEkrani()
        {
            InitializeComponent();
        }

        public int poliklinikID, HastaID, DoktorID;
        SqlCommand komut;
        SqlDataReader okuyucu;

        static DateTime bugun = DateTime.Today;
        string bugunKisa = bugun.ToShortDateString();
        
        public void Poliklinik()
        {
            komut = new SqlCommand("prc_prmPoliklinik_Getir", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                cmb_klinikSec.Items.Add(okuyucu.GetString(1));
            }

            SqlBaglanti.baglanti().Close();
        }
        public void PoliklinikID()
        {
            komut = new SqlCommand("prc_PoliklinikID_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@PoliklinikAdi", SqlDbType.NVarChar, 100);
            komut.Parameters["@PoliklinikAdi"].Value = cmb_klinikSec.Text;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                poliklinikID = okuyucu.GetInt32(0);
            }

            SqlBaglanti.baglanti().Close();
        }
        public void DoktorGetir()
        {
            cmb_hekimSec.Items.Clear();
            komut = new SqlCommand("prc_KlinigeGoreDoktor_Getir", SqlBaglanti.baglanti());

            komut.Parameters.Add("@DoktorKlinikID", SqlDbType.TinyInt);
            komut.Parameters["@DoktorKlinikID"].Value = poliklinikID;

            komut.CommandType = CommandType.StoredProcedure;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                DoktorID = okuyucu.GetInt32(0);
                cmb_hekimSec.Items.Add(okuyucu.GetString(1));
            }
            SqlBaglanti.baglanti().Close();
        }
        void RandevuKontrol()
        {
            komut = new SqlCommand("prc_Randevular_Kontrol", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add("@DoktorID", SqlDbType.Int);
            komut.Parameters["@DoktorID"].Value = DoktorID;

            komut.Parameters.Add("@PoliklinikID", SqlDbType.Int);
            komut.Parameters["@PoliklinikID"].Value = poliklinikID;

            komut.Parameters.Add("@RandevuTarihi", SqlDbType.NVarChar, 15);
            komut.Parameters["@RandevuTarihi"].Value = dateTimePicker1.Value.ToShortDateString();

            groupBox2.Visible = true;

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is Button && item.Text == okuyucu.GetString(0))
                    {
                        item.BackColor = Color.Gray;
                        item.Enabled = false;
                    }
                    else
                    {
                        item.Enabled = true;
                    }
                }
            }
        }
        private void cıkısButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RandevuAra_Click(object sender, EventArgs e)
        {
            RandevuKontrol();
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void RandevuAlmaEkrani_Load(object sender, EventArgs e)
        {
            Poliklinik();

            cmb_SikayetSec.Items.Add("Akne problemi");
            cmb_SikayetSec.Items.Add("Bel ağrısı");
            cmb_SikayetSec.Items.Add("Böbrek sancısı");
            cmb_SikayetSec.Items.Add("Ciltte kuruma");
            cmb_SikayetSec.Items.Add("Göz sulanması");
            cmb_SikayetSec.Items.Add("Kalp çarpıntısı");
            cmb_SikayetSec.Items.Add("Karın ağrısı");
            cmb_SikayetSec.Items.Add("Kulak ağrısı");
            cmb_SikayetSec.Items.Add("Kulak çınlaması");
            cmb_SikayetSec.Items.Add("Mide bulantısı");
            cmb_SikayetSec.Items.Add("Mide yanması");
            cmb_SikayetSec.Items.Add("Nefes darlığı");
            cmb_SikayetSec.Items.Add("Uzağı Bulanık görme");
           
            



        }

        private void cmb_klinikSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoliklinikID();
            DoktorGetir();
        }
        Button btn;
        private void b_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
        }

        private void cmb_SikayetSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_SikayetSec.SelectedIndex)
            {
                case 0 :
                    MessageBox.Show("Cildiyeden randevu alınız. "); break;
                case 1:
                    MessageBox.Show("Beyin cerrahisinden randevu alınız. "); break;
                case 2:
                    MessageBox.Show("İç hastalıklarından randevu alınız."); break;
                case 3:
                    MessageBox.Show("Cildiyeden randevu alınız. "); break;
                case 4:
                    MessageBox.Show("Göz hastalıklarından randevu alınız. "); break;
                case 5:
                    MessageBox.Show("İç hastalıklarından randevu alınız. "); break;
                case 6:
                    MessageBox.Show("İç hastalıklarından randevu alınız."); break;
                case 7:
                    MessageBox.Show("Kulak burun boğazdan randevu alınız. "); break;
                case 8:
                    MessageBox.Show("Kulak burun boğazdan randevu alınız."); break;
                case 9:
                    MessageBox.Show("Genel cerrahiden randevu alınız. "); break;
                case 10:
                    MessageBox.Show("Genel cerrahiden randevu alınız. "); break;
                case 11:
                    MessageBox.Show("Göğüs hastalıklarından randevu alınız."); break;
                case 12:
                    MessageBox.Show("Göz hastalıklarından randevu alınız. "); break;

                default:
                    MessageBox.Show("Seçim yapınız");
                    break;






            }
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bugun = Convert.ToDateTime(bugunKisa);
            if (dateTimePicker1.Value < bugun)
            {
                MessageBox.Show("Tarih bugünden az olamaz.");
                dateTimePicker1.Value = bugun;
            }
        }

        private void randevuSec_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("prc_Randevular_Kaydet", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add("@HastaID", SqlDbType.TinyInt);
            komut.Parameters["@HastaID"].Value = HastaID;

            komut.Parameters.Add("@DoktorID", SqlDbType.TinyInt);
            komut.Parameters["@DoktorID"].Value = DoktorID;

            komut.Parameters.Add("@PoliklinikID", SqlDbType.TinyInt);
            komut.Parameters["@PoliklinikID"].Value = poliklinikID;

            komut.Parameters.Add("@RandevuTarihi", SqlDbType.NVarChar, 15);
            komut.Parameters["@RandevuTarihi"].Value = dateTimePicker1.Value.ToShortDateString();

            komut.Parameters.Add("@RandevuSaati", SqlDbType.NVarChar, 10);
            komut.Parameters["@RandevuSaati"].Value = btn.Text;

            komut.ExecuteNonQuery();

            MessageBox.Show("Randevunuz Kaydedildi");

            SqlBaglanti.baglanti().Close();
        }
    }
}
