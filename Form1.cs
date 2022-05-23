using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljoprivredniKombinat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sadrzajMagacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sadrzaj forma = new Sadrzaj();
            forma.Show();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi forma = new Proizvodi();
            forma.Show();
        }

        private void kategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik forma = new Sifarnik("kategorija");
            forma.Show();
        }

        private void magacinpodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik forma = new Sifarnik("magacin");
            forma.Show();
        }

        private void saradniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik forma = new Sifarnik("saradnik");
            forma.Show();
        }
    }
}
