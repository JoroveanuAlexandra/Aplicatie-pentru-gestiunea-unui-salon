using LibrarieModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static AdministrareFisier.Administrare_fisier;
namespace Aplicatie_salon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adaugareAngajatiTabel();
        }

        public void adaugareAngajatiTabel()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nume", "Nume");
            dataGridView1.Columns.Add("Prenume", "Prenume");
            dataGridView1.Columns.Add("Functie", "Functie");
            dataGridView1.Columns.Add("Salariu", "Salariu");
            dataGridView1.Columns.Add("Data_angajarii", "Data_angajarii");
            dataGridView1.Columns.Add("Numar_telefon", "Numar_telefon");
            dataGridView1.Columns.Add("TipAngajat", "TipAngajat");
            Administrare_FisierText angajati = new Administrare_FisierText("date1.txt");
            List<Angajat> ang = new List<Angajat>();
            int o = 1;
            ang = angajati.GetAngajat(out o);
            for (int i = 0; i < ang.Count; i++)
            {
                if (ang[i] == null)
                {
                    continue;
                }
                else
                {
                    dataGridView1.Rows.Add(ang[i].ID_AN, ang[i].Nume, ang[i].Prenume, ang[i].Functie, ang[i].Salariu, ang[i].DataAngajarii, ang[i].Nr_Telefon, ang[i].TipAngajat);

                }

            }
            // dataGridView1.Rows.Add("adas", "sdasda", "asdasd", "asdasd", "asdasd", "asdasd", "asdasd", "asdasd");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
