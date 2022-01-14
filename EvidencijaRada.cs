using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    class EvidencijaRada
    {
        [Browsable(false)]
        public int ID_zaposlenik { get; set; }
        [Browsable(false)]
        public int ID_smjene { get; set; }
        [Browsable(false)]
        public int ID_vrsta_smjene { get; set; }
        [Browsable(false)]
        public int ID_statusa { get; set; }

        [DisplayName("Vrsta smjene")]
        public string VrstaSmjene { get; set; }
        [DisplayName("Početak rada")]
        public string? PocetakRada { get; set; }
        [DisplayName("Kraj rada")]
        public string? KrajRada { get; set; }
        [DisplayName("Vrsta rada")]
        public string VrstaRada { get; set; }
        public string Datum { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
