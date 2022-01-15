using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kompanija;
using Kompanija.QueryEntities;
using Kompanija.Forms;

namespace Kompanija.Forms
{
    public partial class TimoviWideForm : Form
    {
        private string projekat;
        private Vodja v;
        private List<Radnik> radnici;
        public TimoviWideForm()
        {
            InitializeComponent();
        }
        public TimoviWideForm(string projekat)
        {
            InitializeComponent();
            this.projekat = projekat;
        }

        private void TimoviWideForm_Load(object sender, EventArgs e)
        {

            v = DataProvider.nadjiVodjuTima(this.projekat);
            radnici = DataProvider.nadjiRadnike(this.projekat);

            lbvodja.Text = v.ime + " " + v.prezime;

            foreach (Radnik t in radnici)
            {
                dgvRadnici.Rows.Add(t.ime, t.prezime, t.telefon, t.zanimanje, t.plata, t.email);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Vodja v = DataProvider.nadjiVodjuTima(this.projekat);
            List<Radnik> radnici = DataProvider.nadjiRadnike(this.projekat);

            foreach (Radnik r in radnici)
            {
                DataProvider.PromeniSlobodnostRadnika(r.idRadnika, "da");
            }
            DataProvider.obrisiTimoveZaVodju(v.idVodje);

            this.DialogResult = DialogResult.OK;
        }
    }
}
