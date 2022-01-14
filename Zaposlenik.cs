using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    public enum PozicijaZaposlenika { Radnik=1, Racunovoda=2, Direktor=3 }
    public class Zaposlenik
    {
        public int ID { get; set; }
        public PozicijaZaposlenika Pozicija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int BrojDjece { get; set; }
        public int BrojUzdrzavanihOsoba { get; set; }
    }
}
