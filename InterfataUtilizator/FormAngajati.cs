using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocare;

namespace InterfataUtilizator
{
    public partial class FormAngajati : Form
    {

        AdministrareFisierText adminAngajati;
        List<Angajat> angajat = new List<Angajat>();
        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderFunctie;
        private Label lblHeaderNr_tel;
        private Label lblHeaderData_an;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsFunctie;
        private Label[] lblsNr_tel;
        private Label[] lblsData_an;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 35;
        public FormAngajati()
        {
            //string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            //string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminAngajati = new AdministrareFisierText("date1.txt");

            InitializeComponent();

        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {
            AfiseazaAngajati();
            this.CenterToScreen();
        }

        private void AfiseazaAngajati()
        {

            //MessageBox.Show("test");
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.CornflowerBlue;
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.Controls.Add(lblHeaderNume);

            lblHeaderPrenume =new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Prenume";
            lblHeaderPrenume.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderPrenume.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblHeaderPrenume);

            lblHeaderFunctie = new Label();
            lblHeaderFunctie.Width = LATIME_CONTROL;
            lblHeaderFunctie.Text = "Functie";
            lblHeaderFunctie.Left = OFFSET_X +2* DIMENSIUNE_PAS_X;
            lblHeaderFunctie.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblHeaderFunctie);

            lblHeaderNr_tel = new Label();
            lblHeaderNr_tel.Width = LATIME_CONTROL;
            lblHeaderNr_tel.Text = "Numar telefon";
            lblHeaderNr_tel.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderNr_tel.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblHeaderNr_tel);

            lblHeaderData_an = new Label();
            lblHeaderData_an.Width = LATIME_CONTROL;
            lblHeaderData_an.Text = "Data angajarii";
            lblHeaderData_an.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderData_an.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblHeaderData_an);

            List<Angajat> angajati = adminAngajati.GetAngajat();
            //int o = 1;
            //angajat = adminAngajati.GetAngajat(out o);
            //ArrayList angajati = adminAngajati.GetAngajat();
            int nrAngajati = angajati.Count;
            lblsNume = new Label[nrAngajati];
            lblsPrenume = new Label[nrAngajati];
            lblsFunctie = new Label[nrAngajati];
            lblsNr_tel = new Label[nrAngajati];
            lblsData_an = new Label[nrAngajati];
            int i= 0;
            foreach(Angajat angajat in angajati)
            {
                //MessageBox.Show(angajat.ToString());
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = angajat.Nume;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsNume[i].ForeColor = Color.MidnightBlue;
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = angajat.Prenume;
                lblsPrenume[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsPrenume[i].ForeColor = Color.MidnightBlue;
                this.Controls.Add(lblsPrenume[i]);

                lblsFunctie[i] = new Label();
                lblsFunctie[i].Width = LATIME_CONTROL;
                lblsFunctie[i].Text = string.Join(" ",angajat.TipFunctie);
                lblsFunctie[i].Left = OFFSET_X + 0;
                lblsFunctie[i].Left = OFFSET_X + 2*DIMENSIUNE_PAS_X;
                lblsFunctie[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsFunctie[i].ForeColor = Color.MidnightBlue;
                this.Controls.Add(lblsFunctie[i]);

                lblsNr_tel[i] = new Label();
                lblsNr_tel[i].Width = LATIME_CONTROL;
                lblsNr_tel[i].Text = angajat.Nr_Telefon;
                lblsNr_tel[i].Left = OFFSET_X + 0;
                lblsNr_tel[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsNr_tel[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsNr_tel[i].ForeColor = Color.MidnightBlue;
                this.Controls.Add(lblsNr_tel[i]);

                lblsData_an[i] = new Label();
                lblsData_an[i].Width = LATIME_CONTROL;
                lblsData_an[i].Text = string.Join(" ",angajat.DataAngajarii);
                lblsData_an[i].Left = OFFSET_X + 0;
                lblsData_an[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsData_an[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsData_an[i].ForeColor = Color.MidnightBlue;
                this.Controls.Add(lblsData_an[i]);
                i++;
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            this.Hide();
        }
    }
}
