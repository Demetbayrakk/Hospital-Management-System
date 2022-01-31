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
    public partial class TaburcuOlmusHastalar : Form
    {
        public TaburcuOlmusHastalar()
        {
            InitializeComponent();
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaburcuOlmusHastalar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("prc_TaburcuOlmusHastalar", SqlBaglanti.baglanti());

            komut.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();

            adapter.Fill(tablo);

            bunifuCustomDataGrid1.DataSource = tablo;
        }
    }
}
