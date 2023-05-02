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
    public partial class SadrzeSlovo : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private string imeIliPrezime;
        private string lokacija;
        private string unos;

        public SadrzeSlovo()
        {
            InitializeComponent();
        }

        private void SadrzeSlovo_Load(object sender, EventArgs e)
        {
            PrikaziRadnike();
        }

        private void PrikaziRadnike()
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void rbnIme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnIme.Checked == true)
                imeIliPrezime = "ime";
        }

        private void rbnPrezime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPrezime.Checked == true)
                imeIliPrezime = "prezime";
        }

        private void rbnPrvo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPrvo.Checked == true)
                unos = tboxSlova.Text;
            lokacija = unos + "%";
        }

        private void rbnSrednjeSlovo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSrednjeSlovo.Checked == true)
                unos = tboxSlova.Text;
            lokacija = "%" + unos + "%";
        }

        private void rbnZadnjeSlovo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnZadnjeSlovo.Checked == true)
                unos = tboxSlova.Text;
            lokacija = "%" + unos;
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();

                // string tekstKomande = "select * from Radnik where ime LIKE 'M%'";
                string tekstKomande = "select * from Radnik where " + imeIliPrezime + " LIKE '" + lokacija + "'";

                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
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

            try
            {
                konekcija.Open();

                string tk = "select COUNT (sfRadnik) from Radnik where " + imeIliPrezime + " LIKE '" + lokacija + "'";

                OleDbCommand komanda = new OleDbCommand(tk, konekcija);
                txtUkupno.Text = komanda.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom prikazivanja broja " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }
    }
}