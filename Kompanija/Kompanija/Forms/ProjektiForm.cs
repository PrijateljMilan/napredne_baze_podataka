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
    public partial class ProjektiForm : Form
    {
        List<Projekat> projekti;
        Sef sef = new Sef();
        public ProjektiForm()
        {
            InitializeComponent();

        }
        public ProjektiForm(Sef s)
        {
            InitializeComponent();
            sef = s;
            
        }
        public void ucitajProjekte()
        {
            projekti = DataProvider.vratiProjekteZaSefa(sef.idSefa);
            string kraj;
            foreach (Projekat p in projekti)
            {
                if (p.datumKraja == DateTime.MinValue)

                    kraj = "";
                else
                    kraj = p.datumKraja.ToShortDateString();

                dgvProjekti.Rows.Add(p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(), kraj);
            }
        }
        private void ProjektiForm_Load(object sender, EventArgs e)
        {
            ucitajProjekte();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajProjekatForm dpf = new DodajProjekatForm(sef);
            if (dpf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvProjekti.Rows.Clear();
                ucitajProjekte();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvProjekti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite projekat koji zelite da izmenite.");
                return;
            }
            String naziv = dgvProjekti.CurrentRow.Cells[0].Value.ToString();
            Projekat p = DataProvider.vratiProjekatPoNazivu(naziv);
            IzmeniProjekatForm ipf = new IzmeniProjekatForm(p);
            if (ipf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvProjekti.Rows.Clear();
                ucitajProjekte();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvProjekti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite projekat koji zelite da uklonite.");
                return;
            }
            String naziv = dgvProjekti.CurrentRow.Cells[0].Value.ToString();
            Projekat p = DataProvider.vratiProjekatPoNazivu(naziv);
            DataProvider.obrisiProjekat(p.idProjekta);
            dgvProjekti.Rows.Clear();
            ucitajProjekte();
        }
    }
}
