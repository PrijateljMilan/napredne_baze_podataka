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
    public partial class VodjaForm : Form
    {
        public Vodja vodjaTima;
        public VodjaForm()
        {
            InitializeComponent();
        }
        public VodjaForm(Vodja v)
        {
            InitializeComponent();
            vodjaTima = v;
        }

        private void VodjaForm_Load(object sender, EventArgs e)
        {
            lbime.Text = vodjaTima.ime;
            lbprezime.Text = vodjaTima.prezime;
            lbemail.Text = vodjaTima.email;
        }

        private void btnFormiraj_Click(object sender, EventArgs e)
        {
            FormirajTimForm ftf = new FormirajTimForm(vodjaTima);
            ftf.ShowDialog();
        }

        private void btnPregledTima_Click(object sender, EventArgs e)
        {
            TimVodjaForm tvf = new TimVodjaForm(vodjaTima);
            tvf.ShowDialog();
        }

        private void btnPregledProjekta_Click(object sender, EventArgs e)
        {
            ProjekatVodjaForm pvf = new ProjekatVodjaForm(vodjaTima);
            pvf.ShowDialog();
        }
    }
}
