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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Podaci_o_radnicima__.Net_
{
    public partial class ZaposleniVreme : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima (.Net)\Podaci o radnicima (.Net)\bin\Debug\baza.mdb");
        private string vrednost;
        private string godZaposlenja;

        public ZaposleniVreme()
        {
            InitializeComponent();
        }

        private void ZaposleniVreme_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik ";
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
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                int god = int.Parse(godZaposlenja);
                string tekstKomande = "select * from Radnik where 'DatumZaposlenja'" + vrednost + " '" + DateTime.Now.AddYears(-god) + "'";
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
                int god = int.Parse(godZaposlenja);
                string tekstKomande = "select COUNT (sfRadnik) from Radnik where  'DatumZaposlenja' " + vrednost + " '" + DateTime.Now.AddYears(-god).ToShortDateString() + "'";

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

        private void rbnVece_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVece.Checked == true)
                vrednost = ">";
        }

        private void rbnManje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnManje.Checked == true)
                vrednost = "<";
        }

        private void rbn2Godine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn2Godine.Checked == true)
                godZaposlenja = "2";
        }

        private void rbn5Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn5Godina.Checked == true)
                godZaposlenja = "5";
        }

        private void rbn10Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn10Godina.Checked == true)
                godZaposlenja = "10";
        }

        private void rbn15Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn15Godina.Checked == true)
                godZaposlenja = "15";
        }

        private void rbn20Godina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn20Godina.Checked == true)
                godZaposlenja = "20";
        }

        private void btnGodina_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                int god = int.Parse(godZaposlenja);
                string tekstKomande = "select * from Radnik where 'DatumZaposlenja'" + vrednost + " '" + DateTime.Parse(dateTimePicker1.Value.Date.ToShortTimeString()) + "'";
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
        }
    }
}