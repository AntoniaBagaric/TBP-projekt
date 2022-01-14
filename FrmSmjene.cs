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
    public partial class FrmSmjene : Form
    {
        public FrmSmjene()
        {
            InitializeComponent();

            PopuniPodatke();

        }


        private List<VrstaSmjene> vrsteSmjene = new List<VrstaSmjene>(); 

        public void PopuniPodatke()
        {
            vrsteSmjene = Evidencija.DohvatiVrsteSmjene();

            dgvSmjene.DataSource = vrsteSmjene;
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {

            VrstaSmjene odabranaSmjena = dgvSmjene.SelectedRows[0].DataBoundItem as VrstaSmjene;

            FrmSatnica frmSatnica = new FrmSatnica(odabranaSmjena);
            frmSatnica.ShowDialog();
        }
    }
}
