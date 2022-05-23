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
    public partial class Sifarnik : Form
    {
        
        string imetabele;
        DataTable tabela;
        SqlDataAdapter adapter;
        string cs = @"Data source = DESKTOP-G6UU3BE; Initial catalog = pkb; Integrated security = true";
        SqlConnection veza;
        public Sifarnik(string kreacija)
        {
            imetabele = kreacija;
            InitializeComponent();
        }
        private void Ucitaj()
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter($"select * from {imetabele}", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            Ucitaj();
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            DataTable update = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (update != null)
            {
                adapter.Update(update);
                this.Close();
            }
        }

 
    }
}
