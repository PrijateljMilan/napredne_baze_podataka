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
    public partial class IzmeniRadnikaForm : Form
    {
        private Radnik radnik;
        public IzmeniRadnikaForm()
        {
            InitializeComponent();
        }
        public IzmeniRadnikaForm(Radnik r)
        {
            this.radnik = r;
            InitializeComponent();
        }

        private void IzmeniRadnikaForm_Load(object sender, EventArgs e)
        {
            txtIme.Text = radnik.ime;
            txtPrezime.Text = radnik.prezime;
            txtEmail.Text = radnik.email;
            txtJMBG.Text = radnik.jmbg;
            txtPlata.Text = radnik.plata;
            txtRacun.Text = radnik.racun;
            txtTelefon.Text = radnik.telefon;

            if (radnik.slobodan == "da"){ cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Da"); }
            else{ cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Ne"); }

            if (radnik.zanimanje == "koder") { cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Koder"); }
            else { cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Tester"); }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DataProvider.izmeniRadnika(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, txtJMBG.Text, txtPlata.Text, cmbSlobodan.SelectedItem.ToString().ToLower(), cmbZanimanje.SelectedItem.ToString().ToLower());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
