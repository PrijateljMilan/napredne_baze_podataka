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
    public partial class DodajProjekatForm : Form
    {
        public string idSefa;
        public List<Vodja> vodje;
        public DodajProjekatForm()
        {
            InitializeComponent();
        }
        public DodajProjekatForm(Sef s)
        {
            InitializeComponent();
            idSefa = s.idSefa;
        }

        private void DodajProjekatForm_Load(object sender, EventArgs e)
        {
            vodje = DataProvider.vratiSveVodje();
            foreach (Vodja s in vodje)
            {
                cmbVodja.Items.Add(s.ime + " " + s.prezime + " " + s.jmbg);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Projekat p = new Projekat();
            p.idSefa = idSefa;
            p.naziv = txtNaziv.Text;
            p.prioritet = cmbPrioritet.Text;
            p.rok = dateTimePicker2.Value;
            p.datumPocetka = dateTimePicker1.Value;
            if (p.datumPocetka > p.rok)
            {
                MessageBox.Show("Neispravni fatumi!");
            }
            else
            {
                Vodja v1 = new Vodja();
                v1 = vodje.ElementAt(cmbVodja.SelectedIndex);

                if (v1 == null)
                {
                    MessageBox.Show("Nevalidan JMBG!");
                }
                else
                {
                    p.idVodje = v1.idVodje;
                    DataProvider.dodajProjekat(p);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
