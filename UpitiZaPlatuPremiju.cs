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
    public partial class UpitiZaPlatuPremiju : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");

        private string grupa;
        private string vrednost;
        private string iznos;
        private int izn;

        public UpitiZaPlatuPremiju()
        {
            InitializeComponent();
        }

        private void gboxGrupa_Enter(object sender, EventArgs e)
        {
        }

        private void rbnPlata_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPlata.Checked == true)
                grupa = "Plata";
        }

        private void rbnPremija_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnPremija.Checked == true)
                grupa = "Premija";
        }

        private void rbnVece_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVece.Checked == true)
                vrednost = ">";
        }

        private void rbnManje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnManje.Checked == true)
                vrednost = "<=";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn15000.Checked == true)
                iznos = "15000";
        }

        private void rbn25000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn25000.Checked == true)
                iznos = "25000";
        }

        private void rbn50000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn50000.Checked == true)
                iznos = "50000";
        }

        private void rbn75000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn75000.Checked == true)
                iznos = "75000";
        }

        private void rbn100000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn100000.Checked == true)
                iznos = "100000";
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                if (txtUnos.Text == "")
                {
                    izn = int.Parse(iznos);
                }
                else
                {
                    izn = int.Parse(txtUnos.Text);
                }
                string tekstKomande = "select * from Radnik where " + grupa + "" + vrednost + "" + izn + "";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                DataTable tabela = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }

            try
            {
                konekcija.Open();
                if (txtUnos.Text == "")
                {
                    izn = int.Parse(iznos);
                }
                else
                {
                    izn = int.Parse(txtUnos.Text);
                }

                string tk = "select COUNT (sfRadnik) from Radnik where " + grupa + "" + vrednost + "" + izn + "";
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

        private void rbn5000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn5000.Checked == true)
                iznos = "5000";
        }

        private void rbn125000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn125000.Checked == true)
                iznos = "125000";
        }

        private void rbn150000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn150000.Checked == true)
                iznos = "150000";
        }

        private void txtUnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpitiZaPlatuPremiju_Load(object sender, EventArgs e)
        {

        }
    }
}