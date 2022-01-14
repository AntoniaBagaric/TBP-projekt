using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___TBP
{
    public partial class FrmObracunPlace : Form
    {
        private Zaposlenik odabraniZaposlenik;
        private List<EvidencijaRada> evidencijaZaZaposlenika;
        private List<VrstaSmjene> vrsteSmjene;

        private float neto = 0.0f;


        public FrmObracunPlace(Zaposlenik zaposlenik)
        {
            InitializeComponent();

            odabraniZaposlenik = zaposlenik;
            PopuniPodatke();
        }


        public void PopuniPodatke()
        {
            evidencijaZaZaposlenika = Evidencija.DohvatiSveEvidencije(DateTime.Now.AddMonths(0)).Where(e => e.ID_zaposlenik == odabraniZaposlenik.ID).ToList();
            vrsteSmjene = Evidencija.DohvatiVrsteSmjene();

            txtZaposlenik.Text = $"{odabraniZaposlenik.Ime} {odabraniZaposlenik.Prezime}";

            evidencijaZaZaposlenika.ForEach(evidencija =>
            {
                int satnica = vrsteSmjene.FirstOrDefault(vrsta => evidencija.ID_vrsta_smjene > 0 && vrsta.id_smjene == evidencija.ID_vrsta_smjene).satnica;

                int isplata = 0;

                            
                if (evidencija.VrstaRada == "GO" || evidencija.VrstaRada == "Bolovanje")
                {
                    isplata = 8 * satnica;
                }

                else
                {
                    int vrijeme = 0;
                    if (DateTime.Parse(evidencija.KrajRada) < DateTime.Parse(evidencija.PocetakRada))
                    {
                        vrijeme = 24 - (DateTime.Parse(evidencija.PocetakRada) - DateTime.Parse(evidencija.KrajRada)).Hours;
                    }
                    else
                    {
                        vrijeme = (DateTime.Parse(evidencija.KrajRada) - DateTime.Parse(evidencija.PocetakRada)).Hours;
                    }


                    isplata = satnica * vrijeme;

                }

                neto += isplata;


                Debug.WriteLine($"{satnica} {evidencija.VrstaSmjene} {evidencija.PocetakRada} {evidencija.KrajRada} {evidencija.Datum} {evidencija.VrstaRada} {isplata}");

            });


            txtNeto.Text = neto.ToString();

            Placa placa = new Placa();
            placa.Neto = neto;
            placa.BrojUzdrzavanihOsoba = odabraniZaposlenik.BrojUzdrzavanihOsoba;
            placa.BrojDjece = odabraniZaposlenik.BrojDjece;

            float osobniOdbitak = placa.OsobniOdbitak();
            txtOsobniOdb.Text = osobniOdbitak.ToString();


            txtMir1.Text = placa.IzracunajMIO1().ToString();
            txtMir2.Text = placa.IzracunajMIO2().ToString();

            txtPoreznaOsnovica.Text = placa.IzracunajPoreznuOsnovicu().ToString();
            txtPorez.Text = placa.IzracunajPorez().ToString();
            txtPrirez.Text = placa.IzracunajPrirez().ToString();
            txtZdravstveno.Text = placa.IzracunajZdravstveno().ToString();

            txtBruto.Text = placa.IzracunajBruto2().ToString();
        }

    }
}
