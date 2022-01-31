using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AdminEkran : Form
    {
        public AdminEkran()
        {
            InitializeComponent();
        }

        private void yatanHastalar_Click(object sender, EventArgs e)
        {
            YatanHastalarAdmin yatanHastalarAdmin = new YatanHastalarAdmin();
            yatanHastalarAdmin.Show();
        }

        private void hastaGEkraniCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaburcuOlanHastalar taburcuOlanHastalar = new TaburcuOlanHastalar();
            taburcuOlanHastalar.Show();
        }

        private void doktorIslemleri_Click(object sender, EventArgs e)
        {
            DoktorIslemleri doktorIslemleri = new DoktorIslemleri();
            doktorIslemleri.Show();
        }

        private void klinikIslemleri_Click(object sender, EventArgs e)
        {
            KlinikIslemleri klinikIslemleri = new KlinikIslemleri();
            klinikIslemleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaburcuOlmusHastalar taburcuOlmusHastalar = new TaburcuOlmusHastalar();
            taburcuOlmusHastalar.Show();
        }
    }
}
