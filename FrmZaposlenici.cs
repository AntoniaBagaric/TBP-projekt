using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___TBP
{
    public partial class FrmZaposlenici : Form
    {
        public FrmZaposlenici()
        {
            InitializeComponent();

            PopuniPodatke();

        }


        private List<Zaposlenik> zaposlenici = new List<Zaposlenik>();

        public PozicijaZaposlenika pretvoriPoziciju(string pozicija)
        {
            switch (pozicija)
            {
                case "Radnik": return PozicijaZaposlenika.Radnik;
                case "Racunovoda": return PozicijaZaposlenika.Racunovoda;
                case "Direktor": return PozicijaZaposlenika.Direktor;
            }

            return PozicijaZaposlenika.Radnik;
        }
        
        public void PopuniPodatke()
        {
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"SELECT * FROM zaposlenik JOIN vrsta_zaposlenika ON id_vrste_zaposlenika = id_vrsta", veza);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                zaposlenici.Add(new Zaposlenik()
                {
                    ID = Convert.ToInt32(reader["id_zaposlenik"]),
                    Ime = reader["ime"].ToString(),
                    Prezime = reader["prezime"].ToString(),
                    OIB = reader["oib"].ToString(),
                    Pozicija = pretvoriPoziciju(reader["naziv"].ToString()),
                    KorisnickoIme = reader["korisnicko_ime"].ToString(),
                    Lozinka = reader["lozinka"].ToString(),
                    BrojDjece =  reader.GetInt32("broj_djece"),
                    BrojUzdrzavanihOsoba = reader.GetInt32("broj_uzdrzavanih_osoba")
                });
            }

            reader.Close();

            dgvZaposlenici.DataSource = zaposlenici;

            veza.Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            Zaposlenik odabraniZaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Zaposlenik;


            FrmDodajRadnika frmDodajRadnika = new FrmDodajRadnika(odabraniZaposlenik);
            frmDodajRadnika.ShowDialog();
        }

        private void btnObracunaj_Click(object sender, EventArgs e)
        {
            Zaposlenik odabraniZaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Zaposlenik;


            FrmObracunPlace frmObracunPlace = new FrmObracunPlace(odabraniZaposlenik);
            frmObracunPlace.ShowDialog();
        }
    }
}
