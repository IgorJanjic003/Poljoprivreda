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

namespace PoljoprivredniKombinat
{
    public partial class Proizvodi : Form
    {
        DataTable tabela;
        DataTable katabela;
        SqlDataAdapter adapter;
        int trenutni = 0;
        string cs = @"Data source = DESKTOP-G6UU3BE; Initial catalog = pkb; Integrated security = true";
        SqlConnection veza;
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sifarnik forma = new Sifarnik("kategorija");
            forma.Show();
            this.Close();
        }
        private void Ucitaj()
        {
            tabela = new DataTable();
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter($"select * from proizvod", veza);

            adapter.Fill(tabela);
            adapter = new SqlDataAdapter($"select * from kategorija", veza);
            katabela = new DataTable();
            adapter.Fill(katabela);

            id.Text = tabela.Rows[trenutni]["id"].ToString();
            proizvodtxt.Text = tabela.Rows[trenutni]["naziv"].ToString();
           

            comboBox1.DataSource = katabela;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
            comboBox1.SelectedValue = Convert.ToInt32(tabela.Rows[trenutni]["id_kategorije"]);

            if (trenutni == 0)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
            }

            if (trenutni == (tabela.Rows.Count - 1))
            {
                button7.Enabled = false;
            }
            else
            {
                button7.Enabled = true;
            }
        }
        private void Proizvodi_Load(object sender, EventArgs e)
        {
            Ucitaj();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            trenutni = 0;
            Ucitaj();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trenutni--;
            Ucitaj();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            trenutni++;
            Ucitaj();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            trenutni = tabela.Rows.Count - 1;
            Ucitaj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(comboBox1.SelectedIndex) != -1)
            {
                veza = new SqlConnection(cs);
                string funkcija = $"INSERT INTO proizvod(naziv, id_kategorije) values('{proizvodtxt.Text}', {comboBox1.SelectedValue})";
                SqlCommand unesi = new SqlCommand(funkcija, veza);
                veza.Open();
                unesi.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
                Ucitaj();
                int nekiid = (int)tabela.Rows[tabela.Rows.Count-1]["id"];
                UnosProizvoda forma = new UnosProizvoda(nekiid);
                forma.Show();
            }
            else
            {
                MessageBox.Show("Izaberite kategoriju iz comboboxa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedIndex) != -1)
            {
                veza = new SqlConnection(cs);
                string funkcija = $"UPDATE proizvod SET naziv = '{proizvodtxt.Text}', id_kategorije = {comboBox1.SelectedValue} where id = {id.Text}";
                SqlCommand menjanje = new SqlCommand(funkcija, veza);
                veza.Open();
                menjanje.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
                Ucitaj();
            }

        }
        //popraviti brisanje
        private void button3_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            SqlCommand brisanje = new SqlCommand("DELETE FROM promag WHERE id_proizvod= " + id.Text, veza);
            veza.Open();
            brisanje.ExecuteNonQuery();
            veza.Close();
            brisanje = new SqlCommand("DELETE FROM proizvod WHERE id= " + id.Text, veza);
            veza.Open();
            brisanje.ExecuteNonQuery();
            veza.Close();

            if (trenutni == (tabela.Rows.Count - 1))
                trenutni = tabela.Rows.Count - 2;
            Ucitaj();

        }
    }
}
