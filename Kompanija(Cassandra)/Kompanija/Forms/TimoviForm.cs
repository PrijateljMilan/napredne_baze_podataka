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
    public partial class TimoviForm : Form
    {
        List<Tim> timovi;
        public TimoviForm()
        {
            InitializeComponent();
        }

        private void TimoviForm_Load(object sender, EventArgs e)
        {

            timovi = DataProvider.vratiTimove();
            foreach (Tim t in timovi)
            {
                dgvTimovi.Rows.Add(t.naziv, t.aktivan);
            }
        }

        private void dgvTimovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nazivProjekta = dgvTimovi.CurrentRow.Cells[0].Value.ToString();
            TimoviWideForm timoviwide = new TimoviWideForm(nazivProjekta);
            timoviwide.Show();
            if (timoviwide.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvTimovi.Rows.Clear();
                timovi = DataProvider.vratiTimove();
                foreach (Tim t in timovi)
                {
                    dgvTimovi.Rows.Add(t.naziv, t.aktivan);
                }
            }
        }
    }
}
