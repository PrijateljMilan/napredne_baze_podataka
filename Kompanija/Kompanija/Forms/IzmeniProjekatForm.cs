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
    public partial class IzmeniProjekatForm : Form
    {
        private List<Vodja> vodje;
        private Projekat stari;
        private String jmbgzaizmenu;
        public IzmeniProjekatForm()
        {
            InitializeComponent();
        }
        public IzmeniProjekatForm(Projekat p)
        {
            InitializeComponent();
            stari = p;
        }

        private void IzmeniProjekatForm_Load(object sender, EventArgs e)
        {
            vodje = DataProvider.vratiSveVodje();
            foreach (Vodja s in vodje)
            {
                cmbVodja.Items.Add(s.ime + " " + s.prezime + " " + s.jmbg);
            }
            Vodja v = DataProvider.GetVodja(stari.idVodje);
            jmbgzaizmenu = v.jmbg;
            txtNaziv.Text = stari.naziv;
            cmbVodja.Text = (v.ime + " " + v.prezime + " " + v.jmbg);
            dateTimePicker1.Value = stari.datumPocetka;
            dateTimePicker2.Value = stari.rok;
            cmbPrioritet.SelectedText = stari.prioritet;
            cmbPrioritet.SelectedValue = stari.prioritet;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Vodja v = DataProvider.vratiVodjuPoJmbgu(jmbgzaizmenu);
            stari.prioritet = cmbPrioritet.Text;
            stari.naziv = txtNaziv.Text;
            stari.idVodje = v.idVodje;
            stari.datumPocetka = dateTimePicker1.Value;
            stari.rok = dateTimePicker2.Value;
            DataProvider.izmeniProjekat(stari);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
