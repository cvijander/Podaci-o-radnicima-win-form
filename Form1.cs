using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Podaci_o_radnicima__.Net_
{
    public partial class Form1 : Form
    {
        // Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb"
        private OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziRadnike();
        }

        private void PrikaziRadnike()
        {
            try
            {
                con.Open();
                string tekstKomande = "select * from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, con);
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
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sif = int.Parse(txtSifraRadnika.Text);
                string im = txtImeRadnika.Text;
                string pr = txtPrezimeRadnika.Text;
                DateTime dat = (DateTime)dateTimePicker1.Value;
                int plat = int.Parse(txtPlataRandnika.Text);
                int prem = int.Parse(txtPremijaRadnika.Text);
                Radnik noviR = new Radnik(sif, im, pr, dat, plat, prem);

                con.Open();
                string tekstKomande = "insert into Radnik values(" + noviR.SifraRadnika + " ,'" + noviR.ImeRadnika + "','" + noviR.PrezimeRadnika + "', '" + noviR.DatumZaposlenja.ToString("dd/MM/yyyy") + " ', " + noviR.PlataRadnika + ", " + noviR.PremijaRadnika + ")";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, con);
                komanda.ExecuteNonQuery();
                con.Close();
                //ObrisiPoljaRadnika();
                PrikaziRadnike();

                MessageBox.Show("Novi radnik je uspesno upisan.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom unosa: " + x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string tekstKomande = "delete from Radnik where sfRadnik =" + txtSifraRadnika.Text;
                OleDbCommand komanda = new OleDbCommand(tekstKomande, con);
                komanda.ExecuteNonQuery();
                con.Close();
                PrikaziRadnike();
                MessageBox.Show("Radnik je uspesno obrisan");
                txtSifraRadnika.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom brisanja radnika " + x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObrisiPoljaRadnika();
        }

        private void ObrisiPoljaRadnika()
        {
            txtSifraRadnika.Text = "";
            txtImeRadnika.Text = "";
            txtPrezimeRadnika.Text = "";
            txtPlataRandnika.Text = "";
            txtPremijaRadnika.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int sif = int.Parse(txtSifraRadnika.Text);
                string im = txtImeRadnika.Text;
                string pr = txtPrezimeRadnika.Text;
                DateTime dat = (DateTime)dateTimePicker1.Value;
                int plat = int.Parse(txtPlataRandnika.Text);
                int prem = int.Parse(txtPremijaRadnika.Text);
                Radnik noviR = new Radnik(sif, im, pr, dat, plat, prem);
                con.Open();
                string tekstKomande = "update Radnik set Ime='" + noviR.ImeRadnika + "',Prezime='" + noviR.PrezimeRadnika + "',DatumZaposlenja='" + noviR.DatumZaposlenja.ToString("dd/MM/yyyy") + "',Plata=" + noviR.PlataRadnika + ",Premija=" + noviR.PremijaRadnika + " where sfRadnik=" + noviR.SifraRadnika;
                OleDbCommand komnada = new OleDbCommand(tekstKomande, con);
                komnada.ExecuteNonQuery();
                con.Close();
                PrikaziRadnike();
                MessageBox.Show("Radnik je uspesno azuriran.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom azuriranja " + x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void txtSifraRadnika_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string tekstKomande = "select * from Radnik where sfRadnik =" + txtSifraRadnika.Text;
                OleDbCommand komanda = new OleDbCommand(tekstKomande, con);
                OleDbDataReader citac = komanda.ExecuteReader();
                if (citac.Read() == true)
                {
                    txtImeRadnika.Text = citac[1].ToString();
                    txtPrezimeRadnika.Text = citac[2].ToString();
                    dateTimePicker1.Value = (DateTime)citac[3];
                    txtPlataRandnika.Text = citac[4].ToString();
                    txtPremijaRadnika.Text = citac[5].ToString();
                }
                else
                {
                    txtImeRadnika.Text = "";
                    txtPrezimeRadnika.Text = "";
                    txtPlataRandnika.Text = "";
                    txtPremijaRadnika.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom prikazivanja radnika  " + x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upiti upiti = new Upiti();
            upiti.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dodaj200RadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj200Radnika dRadnike = new Dodaj200Radnika();
            dRadnike.Show();
        }

        private void dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajRadnikePrekoImenaiPrezimena dRadnikePrekoImePrezime = new DodajRadnikePrekoImenaiPrezimena();
            dRadnikePrekoImePrezime.Show();
        }
    }
}