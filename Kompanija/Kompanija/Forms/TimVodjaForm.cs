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
    public partial class TimVodjaForm : Form
    {
        List<Tim> timovi = new List<Tim>();
        Vodja vodja = new Vodja();
        public TimVodjaForm()
        {
            InitializeComponent();
        }
        public TimVodjaForm(Vodja v)
        {
            InitializeComponent();
            vodja = v;
            timovi = DataProvider.vratTimoveZaVodju(vodja.idVodje);
        }

        private void TimVodjaForm_Load(object sender, EventArgs e)
        {
            String nazivTima = timovi.ElementAt(0).naziv;
            String radnici = "";
            if (timovi != null)
            {
                for (int i = 0; i < timovi.Count; i++)
                {
                    Tim t = timovi.ElementAt(i);
                    nazivTima = t.naziv;
                    if (nazivTima == t.naziv)
                    {
                        Tim t1 = t;
                        while (t1.naziv == t.naziv)
                        {
                            Radnik r = DataProvider.vratiRadnikaPoIdu(t1.idRadnika);
                            radnici += r.ime + " " + r.prezime + " ";

                            i++;
                            if (i < timovi.Count)
                            {
                                t1 = timovi.ElementAt(i);
                            }
                            else break;
                        }
                    }
                    i--;
                    dgvTim.Rows.Add(t.naziv, t.aktivan, radnici);
                    radnici = "";
                }
            }
        }
    }
}
