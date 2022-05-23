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
    public partial class UnosProizvoda : Form
    {
        string cs = @"Data source = DESKTOP-G6UU3BE; Initial catalog = pkb; Integrated security = true";
        SqlConnection veza;
        DataTable tabela;
        int idpro;
        public UnosProizvoda(int nekiid)
        {
            idpro = nekiid;
            InitializeComponent();
        }

        private void UnosProizvoda_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from magacin", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            comboBox1.DataSource = tabela;
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            string funkcija = $"insert into promag(id_proizvod, id_magacin, cena, kolicina)" +
                $" values({idpro}, {comboBox1.SelectedValue}, {textBox2.Text}, {textBox3.Text}) ";
            SqlCommand komanda = new SqlCommand(funkcija, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            MessageBox.Show("Uspesno dodato");
            this.Close();
        }
    }
}
