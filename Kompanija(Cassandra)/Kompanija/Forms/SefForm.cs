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
    public partial class SefForm : Form
    {
        public Sef sef;
        public int vodja;
        public SefForm()
        {
            InitializeComponent();
        }
        public SefForm(Sef s)
        {
            this.sef = s;
            InitializeComponent();
        }

        private void SefForm_Load(object sender, EventArgs e)
        {
            lbime.Text = sef.ime;
            lbprezime.Text = sef.prezime;
            lbemail.Text = sef.email;
            lbjmbg.Text = sef.jmbg;
            lbracun.Text = sef.racun;
            lbtelefon.Text = sef.telefon;
        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            TimoviForm timoviform = new TimoviForm();
            timoviform.Show();
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            RadniciForm radniciform = new RadniciForm();
            radniciform.Show();
        }

        private void btnProjekti_Click(object sender, EventArgs e)
        {
            ProjektiForm projektiform = new ProjektiForm(sef);
            projektiform.Show();
        }
    }
}
