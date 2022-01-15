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
    public partial class ProjekatVodjaForm : Form
    {
        List<Projekat> projekti = new List<Projekat>();
        Vodja vodja = new Vodja();
        public ProjekatVodjaForm()
        {
            InitializeComponent();
        }
        public ProjekatVodjaForm(Vodja v)
        {
            InitializeComponent();
            vodja = v;
            projekti = DataProvider.vratiProjekteZaVodju(vodja.idVodje);
        }

        private void ProjekatVodjaForm_Load(object sender, EventArgs e)
        {
            if (projekti != null)
            {
                foreach (Projekat z in projekti)
                {
                    string kraj;
                    if (z.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = z.datumKraja.ToShortDateString();
                    dgvProjekti.Rows.Add(z.naziv, z.prioritet, z.datumPocetka.ToShortDateString(), z.rok.ToShortDateString(), kraj, z.idProjekta);
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvProjekti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte projekat");
            }
            Projekat p = DataProvider.vratiProjekatPoNazivu(dgvProjekti.CurrentRow.Cells[0].Value.ToString());
            DateTime datumK = dateTimePicker1.Value;
            p.datumKraja = datumK;

            DataProvider.izmeniProjekat(p);

            dgvProjekti.Rows.Clear();
            projekti = DataProvider.vratiProjekteZaVodju(vodja.idVodje);
            if (projekti != null)
            {
                foreach (Projekat z in projekti)
                {
                    string kraj;
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();
                    dgvProjekti.Rows.Add(z.naziv, z.prioritet, z.datumPocetka.ToShortDateString(), z.rok.ToShortDateString(), kraj, z.idProjekta);
                }
            }
        }
    }
}
