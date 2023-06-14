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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.ForeColor = Color.CornflowerBlue;
            this.Text = "Salon Pixie";
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnProgramare_Click(object sender, EventArgs e)
        {

            FormProgramare formProgramare= new FormProgramare();
            formProgramare.Show();
            this.Hide();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            FormAngajati formAngajati = new FormAngajati();
            formAngajati.Show();
            this.Hide();

        }

        private void btnServicii_Click(object sender, EventArgs e)
        {
            FormServicii formServicii = new FormServicii();
            formServicii.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*tbxNumeS.Width = 15;
            tbxNumeS.Text = "Salon Pixie";
            tbxNumeS.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            //tbxNumeS.Left = CenterToScreen;
            tbxNumeS.ForeColor = Color.Purple;
            this.Controls.Add(tbxNumeS);*/
        }

        private void buttonAdaugaSerivicu_Click(object sender, EventArgs e)
        {
            FormParola parola = new FormParola();
           //InterfataServicii inter = new InterfataServicii();
            parola.Show();
            this.Hide();
        }
    }
}
