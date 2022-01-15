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
    public partial class RadniciForm : Form
    {
        private List<Radnik> sviRadnici;
        public RadniciForm()
        {
            InitializeComponent();
        }
        public void ucitajRadnike()
        {
            sviRadnici = DataProvider.vratiRadnike();
            foreach (Radnik r in sviRadnici)
            {
                dgvRadnici.Rows.Add(r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email);
            }
        }
        private void RadniciForm_Load(object sender, EventArgs e)
        {
            ucitajRadnike();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRadnikaForm drf = new DodajRadnikaForm();
            if (drf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvRadnici.Rows.Clear();
                ucitajRadnike();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvRadnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite radnika.");
                return;
            }
            string jmbg = (DataProvider.vratiRadnikaPoEmailu(dgvRadnici.CurrentRow.Cells[5].Value.ToString())).jmbg;
            Radnik r = DataProvider.vratiRadnikaPoJmbgu(jmbg);

            IzmeniRadnikaForm izf = new IzmeniRadnikaForm(r);

            if (izf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvRadnici.Rows.Clear();
                ucitajRadnike();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRadnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite radnika.");
                return;
            }

            string id = (DataProvider.vratiRadnikaPoEmailu(dgvRadnici.CurrentRow.Cells[5].Value.ToString())).idRadnika;
            DataProvider.obrisiRadnika(id);
            dgvRadnici.Rows.Clear();
            ucitajRadnike();
        }
    }
}
