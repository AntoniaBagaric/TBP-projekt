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
    public partial class FrmSatnica : Form
    {
        private VrstaSmjene vrstaSmjene;

        public FrmSatnica(VrstaSmjene vrstaSmjene)
        {
            InitializeComponent();

            this.vrstaSmjene = vrstaSmjene;
            txtSmjena.Text = vrstaSmjene.naziv;
            txtSatnica.Text = vrstaSmjene.satnica.ToString();
        }


        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var veza = Baza.Dohvati.Veza;

           veza.Open();

            using var cmd = new NpgsqlCommand($"UPDATE vrsta_smjene SET satnica = @satnica WHERE id_smjene = @idSmjene ", veza);
            cmd.Parameters.AddWithValue("idSmjene", vrstaSmjene.id_smjene);
            cmd.Parameters.AddWithValue("satnica", int.Parse(txtSatnica.Text));

            cmd.ExecuteNonQuery();

            veza.Close();

            MessageBox.Show("Uspješno ste promijenuli satnicu");

            this.Close();

        }
    }
}
