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
    public partial class ZadajZadatakForm : Form
    {
        public Radnik radnik;
        public Vodja vodja;
        public Zadatak zadatak;
        public ZadajZadatakForm()
        {
            InitializeComponent();
        }
        public ZadajZadatakForm(Radnik radnik, Vodja vodja)
        {
            this.radnik = radnik;
            this.vodja = vodja;
            InitializeComponent();

            this.lbime.Text = this.radnik.ime;
            this.lbprezime.Text = this.radnik.prezime;
            this.lbzanimanje.Text = this.radnik.zanimanje;
            this.lbplata.Text = this.radnik.plata;
        }

        private void ZadajZadatakForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            zadatak = new Zadatak();
            string naziv = txtNaziv.Text;
            string opis = rtbOpis.Text;
            string obavljeno = "ne";
            string aktivan = "da";
            zadatak.idRadnika = this.radnik.idRadnika;
            zadatak.idVodje = this.vodja.idVodje;
            zadatak.naziv = naziv;
            zadatak.obavljeno = obavljeno;
            zadatak.opis = opis;
            zadatak.aktivan = aktivan;
            //SELECT MAX("idVodje") FROM "MyCompany"."Vodja";
            string idVodje = DataProvider.GetVodjaId();
            //MessageBox.Show(idVodje);
            zadatak.idVodje = idVodje;
            zadatak.idZadatka = DataProvider.GetZadatakId();
            DataProvider.ZadajZadatak(zadatak, this.radnik);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
