using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompanija.Forms
{
    public partial class DodajRadnikaForm : Form
    {
        public DodajRadnikaForm()
        {
            InitializeComponent();
        }

        private void DodajRadnikaForm_Load(object sender, EventArgs e)
        {
            cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Koder");
            cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Da");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                DataProvider.dodajRadnika(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtPlata.Text, cmbSlobodan.SelectedItem.ToString().ToLower(), txtTelefon.Text, txtJMBG.Text, txtRacun.Text, cmbZanimanje.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste uneli sve podatke!");
            }
        }
        public bool Validacija()
        {
            if (txtIme.Text.Length != 0 & txtPrezime.Text.Length != 0 & txtEmail.Text.Length != 0 & txtTelefon.Text.Length != 0 & txtRacun.Text.Length != 0 & txtPlata.Text.Length != 0 & txtJMBG.Text.Length != 0 & cmbSlobodan.Text.Length != 0 & cmbZanimanje.Text.Length != 0)
                return true;
            return false;
        }
    }
}
