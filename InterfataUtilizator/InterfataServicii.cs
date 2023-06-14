using NivelStocare;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator
{
    public partial class InterfataServicii : Form
    {
        AdministrareFisierText serviciu = new AdministrareFisierText("date2.txt");
        public InterfataServicii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeserv = textBoxNumeServiciu.Text;
            int Durata = Convert.ToInt32(texboxDurata.Text.Trim());
            int Pret = Convert.ToInt32(textBoxPret.Text.Trim());
            int tip = 0;
            if (radiobob_lung.Checked)
            {
                tip = 0;
            }
            if (radiobobscurt.Checked)
            {
                tip = 1;
            }
            if (radioScari.Checked)
            {
                tip = 2;
            }
            if (radioBreton.Checked)
            {
                tip = 3;
            }
            if (radioStraturi.Checked)
            {
                tip = 4;
            }
            if (radioPixie.Checked)
            {
                tip = 5;
            }
            if (radioNimic.Checked)
            {
                tip = 6;
            }
            serviciu.AddServiciu(new LibrarieModele.Serviciu(1, numeserv, Durata, Pret,tip));
        }

        private void InterfataServicii_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.CenterToScreen();
        }

        private void r_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            this.Hide();
        }

        private void radioNimic_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
