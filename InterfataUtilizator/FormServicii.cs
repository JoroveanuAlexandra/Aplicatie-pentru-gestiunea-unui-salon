using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocare;

namespace InterfataUtilizator
{
    public partial class FormServicii : Form
    {
        AdministrareFisierText adminServicii;
        List<Serviciu> serviciu = new List<Serviciu>();
        public FormServicii()
        {

            InitializeComponent();
            AdministrareFisierText servicii = new AdministrareFisierText("date2.txt");
            List<Serviciu> serviciu = new List<Serviciu>();
            int o = 0;
            serviciu = servicii.GetServiciu(out o);
            adaugareServiciuTabel();


            for (int i = 0; i < serviciu.Count; i++)
            {
                if (serviciu[i] == null)
                {
                    continue;
                }
                else
                {
                    if (serviciu[i].NumeServiciu.Equals("tuns"))
                    {
                        dataGridView1.Rows.Add(serviciu[i].NumeServiciu, serviciu[i].Durata, serviciu[i].Pret, serviciu[i].Tip_Tunsoare);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(serviciu[i].NumeServiciu, serviciu[i].Durata, serviciu[i].Pret);
                    }


                }

            }
        }
        private void FormServicii_Load(object sender, EventArgs e)
        {
            this.Hide();
            //  adaugareServiciuTabel();

            this.CenterToScreen();
        }
        private void btnInapoi_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void adaugareServiciuTabel()
        {
            // dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nume_serviciu", "Nume_serviciu");
            dataGridView1.Columns.Add("Durata", "Durata");
            dataGridView1.Columns.Add("Pret", "Pret");
            dataGridView1.Columns.Add("Tip", "Tip");

        }

        private void FormServicii_Load_1(object sender, EventArgs e)
        {
            // adaugareServiciuTabel();
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.CenterToScreen();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            adminServicii = new AdministrareFisierText("date2.txt");
            int o, u;
            serviciu = adminServicii.GetServiciu(out u);
            for (int i = 0; i < serviciu.Count; i++)
            {
                // MessageBox.Show(servicii[i].NumeServiciu);
                if (serviciu[i] == null)
                {
                    continue;
                }
                else
                {
                    if (serviciu[i].NumeServiciu.ToUpper().Equals(textCauta.Text.ToUpper()))
                    {
                        MessageBox.Show("Serviciul a fost gasit");
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Serviciul nu a fost gasit");
                        break;
                    }

                }
            }
        }
    }
}