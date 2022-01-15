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
    public partial class FormirajTimForm : Form
    {
        public Vodja vodja;
        public List<Radnik> listaSlobodnihRadnika = new List<Radnik>();
        public List<Radnik> listaIzabranihRadnika = new List<Radnik>();
        public FormirajTimForm()
        {
            InitializeComponent();
        }
        public FormirajTimForm(Vodja v)
        {
            InitializeComponent();
            this.vodja = v;
        }
        public void PopuniPodacima()
        {
            listaSlobodnihRadnika = DataProvider.GetSlobodniRadnici();
            foreach (Radnik r in listaSlobodnihRadnika)
            {
                dgvRadniciSlobodni.Rows.Add(r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email);
            }
        }
        private void PopuniPodacimaTim()
        {
            foreach (Radnik r in listaIzabranihRadnika)
            {
                dgvRadniciTm.Rows.Add(r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email);
            }
        }

        private void FormirajTimForm_Load(object sender, EventArgs e)
        {
            this.PopuniPodacima();
            this.PopuniPodacimaTim();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            if (dgvRadniciSlobodni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            string email = dgvRadniciSlobodni.CurrentRow.Cells[5].Value.ToString();
            foreach (Radnik radnik in listaSlobodnihRadnika.ToList())
            {
                if (email == radnik.email)
                {
                    listaIzabranihRadnika.Add(radnik);
                    listaSlobodnihRadnika.Remove(radnik);
                }
            }
            dgvRadniciSlobodni.Rows.Clear();
            this.PopuniPodacima();
            dgvRadniciTm.Rows.Clear();
            this.PopuniPodacimaTim();
        }

        private void btnFormiraj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length != 0)
            {
                foreach (Radnik radnik in listaIzabranihRadnika)
                {
                    Tim tim = new Tim();
                    tim.naziv = txtNaziv.Text;
                    tim.idRadnika = radnik.idRadnika;
                    tim.idVodje = this.vodja.idVodje;
                    tim.aktivan = "da";
                    tim.idTima = DataProvider.GetTimId();
                    DataProvider.AddTim(tim);
                    DataProvider.PromeniSlobodnostRadnika(radnik.idRadnika, "ne");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Unesite naziv tima!"); 
        }

        private void btnZadatak_Click(object sender, EventArgs e)
        {
            if (dgvRadniciTm.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }

            string email = dgvRadniciTm.CurrentRow.Cells[5].Value.ToString();

            foreach (Radnik radnik in listaIzabranihRadnika)
            {
                if (radnik.email == email)
                {
                    ZadajZadatakForm zadajZadatakForm = new ZadajZadatakForm(radnik, this.vodja);
                    if (zadajZadatakForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        dgvRadniciSlobodni.Rows.Clear();
                        this.PopuniPodacima();
                        dgvRadniciTm.Rows.Clear();
                        this.PopuniPodacimaTim();
                    }
                }
            }
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (dgvRadniciTm.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            string email = dgvRadniciTm.CurrentRow.Cells[5].Value.ToString();

            foreach (Radnik radnik in listaIzabranihRadnika.ToList())
            {
                if (email == radnik.email)
                {
                    listaSlobodnihRadnika.Add(radnik);
                    listaIzabranihRadnika.Remove(radnik);
                }
            }
            dgvRadniciSlobodni.Rows.Clear();
            this.PopuniPodacima();
            dgvRadniciTm.Rows.Clear();
            this.PopuniPodacimaTim();
        }
    }
}
