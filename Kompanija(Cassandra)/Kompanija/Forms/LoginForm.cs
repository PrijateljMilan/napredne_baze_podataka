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

namespace Kompanija
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length != 0 & txtSifra.Text.Length != 0)
            {
                string stranica = DataProvider.login(txtEmail.Text, txtSifra.Text);

                if (stranica == null)
                {
                    MessageBox.Show("Unesite validan email i sifru.");
                }
                else if (stranica == "sef")
                {
                    Sef sef = new Sef();
                    sef = DataProvider.vratiSefaPoEmailu(txtEmail.Text);
                    SefForm sefform = new SefForm(sef);
                    sefform.Show();
                }
                else if (stranica == "vodja")
                {
                    Vodja vodja = new Vodja();
                    vodja = DataProvider.vratiVodjuPoEmailu(txtEmail.Text);
                    VodjaForm profilVodje = new VodjaForm(vodja);
                    profilVodje.Show();
                }
                else if (stranica == "radnik")
                {
                    Radnik radnik = new Radnik();
                    radnik = DataProvider.vratiRadnikaPoEmailu(txtEmail.Text);
                    RadnikForm radnikform = new RadnikForm(radnik);
                    radnikform.Show();
                }
            }
        }
    }
}