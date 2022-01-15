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
    public partial class RadnikForm : Form
    {
        private Radnik radnik = new Radnik();
        private List<Zadatak> zadaci = new List<Zadatak>();
        public RadnikForm()
        {
            InitializeComponent();
        }
        public RadnikForm(Radnik r)
        {
            this.radnik = r;
            this.zadaci = DataProvider.vratiZadatkeZaRadnika(radnik.idRadnika);
            InitializeComponent();
        }

        private void RadnikForm_Load(object sender, EventArgs e)
        {
            lbime.Text = radnik.ime;
            lbprezime.Text = radnik.prezime;
            lbemail.Text = radnik.email;
            if (zadaci != null)
            {
                foreach (Zadatak z in zadaci)
                {
                    dgvZadaci.Rows.Add(z.naziv, z.obavljeno, z.opis);
                }

            }
        }
    }
}
