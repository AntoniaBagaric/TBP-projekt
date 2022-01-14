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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();

            if (Baza.Dohvati.Zaposlenik.Pozicija == PozicijaZaposlenika.Radnik)
            {
                btnDodajRadnika.Enabled = false;
                btnObracunajPlacu.Enabled = false;
                btnZaposlenici.Enabled = false;
                btnPromSatnicu.Enabled = false;
            }
        }

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            FrmDodajRadnika frmDodajRadnika = new FrmDodajRadnika();
            frmDodajRadnika.ShowDialog();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            FrmEvidentiraj frmEvidentiraj = new FrmEvidentiraj();
            frmEvidentiraj.ShowDialog();
        }

        private void btnObracunajPlacu_Click(object sender, EventArgs e)
        {
            
                FrmEvidencijaIObracun frmEvidencijaIObracun = new FrmEvidencijaIObracun();
                frmEvidencijaIObracun.ShowDialog();


        }

        private void btnPromSatnicu_Click(object sender, EventArgs e)
        {
            FrmSmjene frmSmjene = new FrmSmjene();
            frmSmjene.ShowDialog();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frmZaposlenici = new FrmZaposlenici();
            frmZaposlenici.ShowDialog();
        }

        private void btnObracun_Click(object sender, EventArgs e)
        {
            FrmObracunPlace frmObracun = new FrmObracunPlace(Baza.Dohvati.Zaposlenik);
            frmObracun.ShowDialog();
        }
    }
}
