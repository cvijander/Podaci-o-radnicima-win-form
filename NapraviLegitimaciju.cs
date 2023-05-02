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
    public partial class NapraviLegitimaciju : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private List<Radnik> listaRadnika = new List<Radnik>();
        private Radnik odabraniRadnik;

        public NapraviLegitimaciju()
        {
            InitializeComponent();
        }

        private void NapraviLegitimaciju_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik order by sfRadnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read() == true)
                {
                    int sifraRadnika = int.Parse(citac[0].ToString());
                    string ime = citac[1].ToString();
                    string prezime = citac[2].ToString();
                    DateTime datumZaposlenja = DateTime.Parse(citac[3].ToString());
                    int plata = int.Parse(citac[4].ToString());
                    int premija = int.Parse(citac[5].ToString());
                    Radnik odabrani = new Radnik(sifraRadnika, ime, prezime, datumZaposlenja, plata, premija);
                    listaRadnika.Add(odabrani);
                    lboxRadnici.Items.Add(odabrani.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska " + ex.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            MessageBox.Show("" + index);
        }

        private void lboxRadnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxRadnici.SelectedIndex;
            odabraniRadnik = listaRadnika[index];
            rtboxInfo.Text = "Sifra radnika:\t" + odabraniRadnik.SifraRadnika + "\n" +
                "Ime radnika:\t" + odabraniRadnik.ImeRadnika + "\n" +
                "Prezime radnika:\t" + odabraniRadnik.PrezimeRadnika + "\n" +
                "Datum zaposlenja:\t" + odabraniRadnik.DatumZaposlenja.ToShortDateString() + "\n" +
                "Plata radnika:\t" + odabraniRadnik.PlataRadnika + "\n" +
                "Premija radnika:\t" + odabraniRadnik.PremijaRadnika;
        }

        private void btnPredjinaLegitimaciju_Click(object sender, EventArgs e)
        {
            if (rtboxInfo.Text == "")
            {
                MessageBox.Show("Greska Morate da odaberete jednog radnika.");
                return;
            }
            legitimacija leg = new legitimacija(odabraniRadnik);
            leg.Show();
        }
    }
}