using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Podaci_o_radnicima__.Net_
{
    public class Radnik
    {
        private int sifraRadnika;
        private string imeRadnika;
        private string prezimeRadnika;
        private DateTime datumZaposlenja;
        private int plataRadnika;
        private int premijaRadnika;

        public Radnik(int sifraRadnika, string imeRadnika, string prezimeRadnika, DateTime datumZaposlenja, int plataRadnika, int premijaRadnika)
        {
            this.SifraRadnika = sifraRadnika;
            this.ImeRadnika = imeRadnika;
            this.PrezimeRadnika = prezimeRadnika;
            this.DatumZaposlenja = datumZaposlenja;
            this.PlataRadnika = plataRadnika;
            this.PremijaRadnika = premijaRadnika;
        }

        public int SifraRadnika { get => sifraRadnika; set => sifraRadnika = value; }
        public string ImeRadnika { get => imeRadnika; set => imeRadnika = value; }
        public string PrezimeRadnika { get => prezimeRadnika; set => prezimeRadnika = value; }
        public DateTime DatumZaposlenja { get => datumZaposlenja; set => datumZaposlenja = value; }
        public int PlataRadnika { get => plataRadnika; set => plataRadnika = value; }
        public int PremijaRadnika { get => premijaRadnika; set => premijaRadnika = value; }

        public override string ToString()
        {
            return sifraRadnika + " " + imeRadnika + " " + prezimeRadnika;
        }
    }
}