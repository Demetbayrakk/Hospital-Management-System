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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Form içinde form açabilmek için 
        }

        HastaGiris hGirisEkran;
        private void hastaGirisButonu_Click(object sender, EventArgs e)
        {
            if (hGirisEkran == null || hGirisEkran.IsDisposed)
            {
                hGirisEkran = new HastaGiris();
                hGirisEkran.Show();
            }
            else
            {
                hGirisEkran.Focus();
            }
        }

        DoktorGiris dGirisEkran;
        private void doktorGirisButonu_Click(object sender, EventArgs e)
        {
            if (dGirisEkran == null || dGirisEkran.IsDisposed)
            {
                dGirisEkran = new DoktorGiris();
                dGirisEkran.Show();
            }
            else
            {
                dGirisEkran.Focus();
            }
        }

        AdminGiris aGirisEkran;
        private void asistanGirisButonu_Click(object sender, EventArgs e)
        {
            if (aGirisEkran == null || aGirisEkran.IsDisposed)
            {
                aGirisEkran = new AdminGiris();
                aGirisEkran.Show();
            }
            else
            {
                aGirisEkran.Focus();
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
