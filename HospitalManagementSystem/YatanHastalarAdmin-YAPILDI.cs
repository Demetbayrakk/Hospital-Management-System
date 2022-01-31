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
    public partial class YatanHastalarAdmin : Form
    {
        public YatanHastalarAdmin()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable tablo;
        private void YatanHastalarAdmin_Load(object sender, EventArgs e)
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
    }
}
