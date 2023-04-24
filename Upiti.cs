using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podaci_o_radnicima__.Net_
{
    public partial class Upiti : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");

        private string velicina;
        private string vrednost;

        public Upiti()
        {
            InitializeComponent();
        }

        private void rbnMax_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMax.Checked == true)
                velicina = "MAX";
        }

        private void rbtMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMin.Checked == true)
                velicina = "MIN";
        }

        private void rbtSifraRadnika_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSifraRadnika.Checked == true)
                vrednost = "sfRadnik";
        }

        private void rbtPlata_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPlata.Checked == true)
                vrednost = "Plata";
        }

        private void rbnPremija_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPremija.Checked == true)
                vrednost = "Premija";
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select " + velicina + "(+" + vrednost + ") from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                textBox1.Text = komanda.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom prikaza " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik where " + vrednost + "= " + textBox1.Text.ToString();
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                DataTable tabela = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska u prikazu " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}