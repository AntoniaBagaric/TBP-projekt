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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"SELECT * FROM zaposlenik z JOIN vrsta_zaposlenika v ON z.id_vrsta = v.id_vrste_zaposlenika " +
                $"WHERE korisnicko_ime='{txtKorisnickoIme.Text}' " +
                $"AND lozinka='{txtLozinka.Text}'", veza);
            var reader = cmd.ExecuteReader();
            reader.Read();

            string nazivPozicije = reader["naziv"].ToString();
            switch (nazivPozicije)
            {
                case "Radnik": Baza.Dohvati.Zaposlenik.Pozicija = PozicijaZaposlenika.Radnik; break;
                case "Racunovoda": Baza.Dohvati.Zaposlenik.Pozicija = PozicijaZaposlenika.Racunovoda; break;
                case "Direktor": Baza.Dohvati.Zaposlenik.Pozicija = PozicijaZaposlenika.Direktor; break;
            }

            Baza.Dohvati.Zaposlenik.ID = Convert.ToInt32(reader["id_zaposlenik"]);
            Baza.Dohvati.Zaposlenik.Ime = reader.GetString("ime"); 
            Baza.Dohvati.Zaposlenik.Prezime = reader.GetString("prezime");

            veza.Close();

            FrmIzbornik frmIzbornik = new FrmIzbornik();
            frmIzbornik.ShowDialog();
            this.Close();
        }
    }
}
