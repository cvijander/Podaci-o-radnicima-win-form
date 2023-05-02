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
    public partial class ImeiPrezime : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private string ime = "";
        private string prezime = "";

        public ImeiPrezime()
        {
            InitializeComponent();
        }

        private void ImeiPrezime_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select ime, prezime from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                DataTable tabela = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
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
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                ime = txtIme.Text;
                prezime = txtPrezime.Text;
                string tekstKomande = "";
                if (ime != "" && prezime != "")
                {
                    ime = ime.Substring(0, 1).ToUpper() + ime.Substring(1).ToLower();
                    prezime = prezime.Substring(0, 1).ToUpper() + prezime.Substring(1).ToLower();
                    tekstKomande = "select * from Radnik where Ime ='" + ime + "' and Prezime='" + prezime + "' ";
                }
                else if (ime != "")
                {
                    ime = ime.Substring(0, 1).ToUpper() + ime.Substring(1).ToLower();
                    tekstKomande = "select * from Radnik where Ime ='" + ime + "'";
                }
                else
                {
                    prezime = prezime.Substring(0, 1).ToUpper() + prezime.Substring(1).ToLower();
                    tekstKomande = "select * from Radnik where Prezime='" + prezime + "'";
                }
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                DataTable tabela = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
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
                ime = txtIme.Text;
                prezime = txtPrezime.Text;
                string tekstKomande = "";
                if (ime != "" && prezime != "")
                {
                    ime = ime.Substring(0, 1).ToUpper() + ime.Substring(1).ToLower();
                    prezime = prezime.Substring(0, 1).ToUpper() + prezime.Substring(1).ToLower();
                    tekstKomande = "select COUNT (sfRadnik) from Radnik where Ime ='" + ime + "' and Prezime='" + prezime + "' ";
                }
                else if (ime != "")
                {
                    ime = ime.Substring(0, 1).ToUpper() + ime.Substring(1).ToLower();
                    tekstKomande = "select COUNT (sfRadnik) from Radnik where ime ='" + ime + "'";
                }
                else
                {
                    prezime = prezime.Substring(0, 1).ToUpper() + prezime.Substring(1).ToLower();
                    tekstKomande = "select COUNT (sfRadnik) from Radnik where prezime ='" + prezime + "'";
                }
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                txtUkupno.Text = komanda.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska u prebrojavanju " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }
    }
}