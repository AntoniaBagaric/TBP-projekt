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
    public partial class FrmEvidentiraj : Form
    {
        public FrmEvidentiraj()
        {
            InitializeComponent();
        }

        private void btnZapocniSmjenu_Click(object sender, EventArgs e)
        {
            label1.Text = $"Smjena započela u {DateTime.Now}";
            btnZapocniSmjenu.Enabled = false;
            btnZavrsiSmjenu.Enabled = true;

            var veza = Baza.Dohvati.Veza;

            int idTrenutneSmjene = Smjena.DohvatiTrenutnuSmjenu();

            veza.Open();

            using var cmd = new NpgsqlCommand($"INSERT INTO evidencija_rada (id_zaposlenik, id_smjene, id_statusa, pocetak_rada) VALUES (@idZaposlenik, @idSmjene, 1, @vrijemePocetka) ", veza);
            cmd.Parameters.AddWithValue("idZaposlenik", Baza.Dohvati.Zaposlenik.ID);
            cmd.Parameters.AddWithValue("idSmjene", idTrenutneSmjene);
            cmd.Parameters.AddWithValue("vrijemePocetka", DateTime.Now.TimeOfDay);

            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno ste evidentirali svoj početak smjene!", "Great success");
        }

        private void btnZavrsiSmjenu_Click(object sender, EventArgs e)
        {
            btnZavrsiSmjenu.Enabled = false;

            var veza = Baza.Dohvati.Veza;

            int idTrenutneSmjene = Smjena.DohvatiTrenutnuSmjenu();

            veza.Open();

            using var cmd = new NpgsqlCommand($"UPDATE evidencija_rada SET kraj_rada = @vrijemeKraja WHERE id_zaposlenik = @idZaposlenik AND id_smjene = @idSmjene ", veza);
            cmd.Parameters.AddWithValue("idZaposlenik", Baza.Dohvati.Zaposlenik.ID);
            cmd.Parameters.AddWithValue("idSmjene", idTrenutneSmjene);
            cmd.Parameters.AddWithValue("vrijemeKraja", DateTime.Now.TimeOfDay);

            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno ste evidentirali kraj svoje smjene!", "Great success");
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"INSERT INTO godisnji_odmori (pocetak_go, kraj_go, id_zaposlenika) VALUES (@pocetakGO, @krajGO, @idZaposlenika) ", veza);
            cmd.Parameters.AddWithValue("pocetakGO", dtpPocGO.Value);
            cmd.Parameters.AddWithValue("krajGO", dtpKrajGO.Value);
            cmd.Parameters.AddWithValue("idZaposlenika", Baza.Dohvati.Zaposlenik.ID);
            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno ste evidentirali godišnji odmor! Lijepo se odmorite :)", "Great success");

            this.Close();
        }

        private void btnBolovanje_Click(object sender, EventArgs e)
        {
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"INSERT INTO bolovanja (pocetak_bolovanja, kraj_bolovanja, id_zaposlenika) VALUES (@pocetakBolovanja, @krajBolovanja, @idZaposlenika) ", veza);
            cmd.Parameters.AddWithValue("pocetakBolovanja", dtpPocBolovanje.Value);
            cmd.Parameters.AddWithValue("krajBolovanja", dtpKrajBolovanje.Value);
            cmd.Parameters.AddWithValue("idZaposlenika", Baza.Dohvati.Zaposlenik.ID);
            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno ste evidentirali svoje bolovanje!", "Great success");

            this.Close();
        }
    }
}
