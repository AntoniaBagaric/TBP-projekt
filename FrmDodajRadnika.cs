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
    public partial class FrmDodajRadnika : Form
    {
        private Zaposlenik odabraniZaposlenik;

        public FrmDodajRadnika()
        {
            InitializeComponent();
            cmbPozicija.DataSource = Enum.GetValues(typeof(PozicijaZaposlenika));
        }

        public FrmDodajRadnika(Zaposlenik zaposlenik)
        {
            InitializeComponent();

            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtOIB.Text = zaposlenik.OIB;
            txtKorIme.Text = zaposlenik.KorisnickoIme;
            txtLozinka.Text = zaposlenik.Lozinka;
            txtDjece.Value = zaposlenik.BrojDjece;
            txtUzdrzavane.Value = zaposlenik.BrojUzdrzavanihOsoba;
            cmbPozicija.DataSource = Enum.GetValues(typeof(PozicijaZaposlenika));
            cmbPozicija.SelectedItem = zaposlenik.Pozicija;

            odabraniZaposlenik = zaposlenik;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"INSERT INTO zaposlenik (ime, prezime, oib, korisnicko_ime, lozinka, id_vrsta, broj_djece, broj_uzdrzavanih_osoba)" +
                                              $" VALUES (@ime, @prezime, @oib, @korisnicko_ime, @lozinka, @id_vrsta, @broj_djece, @broj_uzdrzavanih_osoba) ", veza);


            if (odabraniZaposlenik != null)
            {
                cmd.CommandText = "UPDATE zaposlenik SET ime = @ime, prezime = @prezime, oib = @oib, id_vrsta = @id_vrsta, korisnicko_ime = @korisnicko_ime, lozinka = @lozinka, broj_djece = @broj_djece, broj_uzdrzavanih_osoba = @broj_uzdrzavanih_osoba " +
                    "WHERE id_zaposlenik = @id_zaposlenik";
                cmd.Parameters.AddWithValue("id_zaposlenik", odabraniZaposlenik.ID);
            }

            cmd.Parameters.AddWithValue("ime", txtIme.Text);
            cmd.Parameters.AddWithValue("prezime", txtPrezime.Text);
            cmd.Parameters.AddWithValue("oib", txtOIB.Text);
            cmd.Parameters.AddWithValue("id_vrsta", (int)(PozicijaZaposlenika)cmbPozicija.SelectedItem);
            cmd.Parameters.AddWithValue("korisnicko_ime", txtKorIme.Text);
            cmd.Parameters.AddWithValue("lozinka", txtLozinka.Text);
            cmd.Parameters.AddWithValue("broj_djece", int.Parse(txtDjece.Text));
            cmd.Parameters.AddWithValue("broj_uzdrzavanih_osoba", int.Parse(txtUzdrzavane.Text));


            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno obavljen posao!", "Great success");


            this.Close();
        }
    }
}
