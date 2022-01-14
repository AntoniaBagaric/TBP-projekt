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
    public partial class FrmEvidencijaIObracun : Form
    {
        private List<EvidencijaRada> evidencije;

        public FrmEvidencijaIObracun()
        {
            InitializeComponent();

            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.CustomFormat = "MM/yyyy";
            dtpDatum.ShowUpDown = true;

            evidencije = new List<EvidencijaRada>();
        }


        private void btnDohvatiObracun_Click(object sender, EventArgs e)
        {
            dgvZaposlenici.DataSource = null;

            evidencije = Evidencija.DohvatiSveEvidencije(dtpDatum.Value);

            dgvZaposlenici.DataSource = evidencije;
        }
    }
}
