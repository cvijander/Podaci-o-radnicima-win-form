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
using System.Windows.Forms.VisualStyles;

namespace Podaci_o_radnicima__.Net_
{
    public partial class Dodaj200Radnika : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private Random R = new Random();

        public Dodaj200Radnika()
        {
            InitializeComponent();
        }

        private void Dodaj200Radnika_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> IM = new List<string>();
            List<string> Pr = new List<string>();
            IM.Add("Ana"); IM.Add("Milica"); IM.Add("Tijana"); IM.Add("Teodora"); IM.Add("Ivana");
            IM.Add("Bojan"); IM.Add("Igor"); IM.Add("Uros"); IM.Add("Bogdan"); IM.Add("Goran");
            Pr.Add("Mitrovic"); Pr.Add("Nikic"); Pr.Add("Diklic"); Pr.Add("Ducic"); Pr.Add("Matic");
            Pr.Add("Jovanov"); Pr.Add("Stojanov"); Pr.Add("Mitrov"); Pr.Add("Cvetkovic"); Pr.Add("Cvetic");

            try
            {
                konekcija.Open();
                int brojRadnika = int.Parse(txtBrojRadnika.Text);
                int pocetnaSifra = int.Parse(txtPocetnaSifra.Text);
                pocetnaSifra = pocetnaSifra + 1;

                for (int i = 0; i < brojRadnika; i++)
                {
                    int sifra = pocetnaSifra + i;
                    string ime = IM[R.Next(0, 10)];
                    string prezime = Pr[R.Next(0, 10)];
                    DateTime datum = DateTime.Now.AddDays(-1 * R.Next(10, 10000));
                    int plata = R.Next(40000, 150000);
                    int premija = R.Next(0, 25000);
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
    }
}