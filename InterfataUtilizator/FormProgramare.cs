using LibrarieModele;

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
    public partial class FormProgramare : Form
    {
        List<Programare> programari = new List<Programare>();
        List<Serviciu> servicii = new List<Serviciu>();
        List<Angajat> angajatu = new List<Angajat>();
        AdministrareFisierText adminangajati;
        AdministrareFisierText adminservicii;
        int count = 0;
        IStocareData adminProgramare;
        public FormProgramare()
        {
            InitializeComponent();
            adminangajati = new AdministrareFisierText("date1.txt");
            adminservicii = new AdministrareFisierText("date2.txt");
            int o, u;
            servicii = adminservicii.GetServiciu(out u);
            angajatu = adminangajati.GetAngajat();
            for (int i = 0; i < servicii.Count; i++)
            {
                // MessageBox.Show(servicii[i].NumeServiciu);
                if(servicii[i] == null) {
                    continue;
                }
                else
                {
                    if (servicii[i].NumeServiciu.Equals("tuns"))
                    {
                        listBoxServicii.Items.Add(string.Format("{0}, {1}", servicii[i].NumeServiciu, servicii[i].Tip_Tunsoare));
                    }
                    else
                    {
                        listBoxServicii.Items.Add(servicii[i].NumeServiciu);
                    }
                    
                }
            }
            for (int i = 0; i < angajatu.Count; i++)
            {
                if(angajatu[i] == null)
                {
                    continue;
                }else
                {
                    listBoxAngajati.Items.Add(angajatu[i].NumeComplet);

                }

            }

        }

        private void FormProgramare_Load(object sender, EventArgs e)
        {
            listBoxServicii.SelectionMode = SelectionMode.MultiExtended;
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void LoadClasses()
        {
            
            for (int i = 0; i < angajatu.Count; i++)
            {
                listBoxAngajati.Items.Add(angajatu[i].NumeComplet);

            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAngajati_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tbxCauta_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (tbxNume.Text == string.Empty)
                MessageBox.Show("Nu ati introdus un nume corect");
            else
            if (listBoxServicii.SelectedItem == null)
            {

                MessageBox.Show("Nu ati selectat serviciul dorit");
           
            }
            else
            if (listBoxAngajati.SelectedItem == null)
            {

                MessageBox.Show("Nu ati selectat angajatul");
            }
            

        }
        
        private void AfisareProgramareInControlListbox(List<Programare> programare)
        {
            /*listAfisare.Items.Clear();
            foreach (Programare program in programare)
            {
                listAfisare.Items.Add(programare);
            }*/
        }

        private void listBoxProg_SelectedIndexChanged_2(object sender, EventArgs e)
        {
           
        }

        private void listBoxServicii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void tbxNume_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridProgramare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {

        }
        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            List<Programare> programare = adminProgramare.GetProgramare();
            AfisareProgramareInControlListbox(programare);
        }
    }
}
