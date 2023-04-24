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
    public partial class DodajRadnikePrekoImenaiPrezimena : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private Random R = new Random();
        private List<string> listaImena = new List<string>();
        private List<string> listaPrezimena = new List<string>();

        public DodajRadnikePrekoImenaiPrezimena()
        {
            InitializeComponent();
        }

        private void btnIme_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string novoIme = ime.Substring(0, 1).ToUpper() + ime.Substring(1).ToLower();
            lboxIme.Items.Add(novoIme);
            listaImena.Add(novoIme);
            txtIme.Clear();
        }

        private void DodajRadnikePrekoImenaiPrezimena_Load(object sender, EventArgs e)
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
                DataTable tabela = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                konekcija.Close();
                BrojRadnika();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom prikaza radnika " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void BrojRadnika()
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select MAX(sfRadnik) from Radnik ";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                txtPocetnaSifra.Text = komanda.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom pretrazivanja najvece sifre " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void btnUnesiteImenaUBazu_Click(object sender, EventArgs e)
        {
            foreach (string im in listaImena)
            {
                MessageBox.Show(im);
            }
        }

        private void btnPrezime_Click(object sender, EventArgs e)
        {
            string prezime = txtPrezime.Text;
            string novoPrezime = prezime.Substring(0, 1).ToUpper() + prezime.Substring(1).ToLower();
            lboxPrezime.Items.Add(novoPrezime);
            listaPrezimena.Add(novoPrezime);
            txtPrezime.Clear();
        }

        private void btnUnesitePrezimenaUBazu_Click(object sender, EventArgs e)
        {
            foreach (string pr in listaPrezimena)
            {
                MessageBox.Show(pr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                int brojRadnika = int.Parse(txtBrojRadnika.Text);
                int pocetnaSifra = int.Parse(txtPocetnaSifra.Text);
                pocetnaSifra = pocetnaSifra + 1;

                for (int i = 0; i < brojRadnika; i++)
                {
                    int sifra = pocetnaSifra + i;
                    string ime = listaImena[R.Next(0, listaImena.Count)];
                    string prezime = listaPrezimena[R.Next(0, listaPrezimena.Count)];
                    DateTime datum = DateTime.Now.AddDays(-1 * R.Next(10, 10000));
                    int plata = R.Next(int.Parse(txtNajmanjaPlata.Text), int.Parse(txtNajvecaPlata.Text));
                    int premija = R.Next(int.Parse(txtNajmanjaPremija.Text), int.Parse(txtNajvecaPremija.Text));
                    string tekstKomande = "insert into Radnik values (" + sifra + ",'" + ime + "','" + prezime + "','" + datum.ToString("dd/MM/yyyy") + "'," + plata + "," + premija + " )";
                    OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                    komanda.ExecuteNonQuery();
                }
                konekcija.Close();
                PrikaziRadnike();

                MessageBox.Show("Uspesno je upisano " + txtBrojRadnika.Text + " radnika,  sada zadnja sfRadnika je " + txtPocetnaSifra.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom unosa " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }
    }
}