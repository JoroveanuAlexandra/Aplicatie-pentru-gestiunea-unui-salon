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
    public partial class FormParola : Form
    {
        public FormParola()
        {
            InitializeComponent();
        }

        private void FormParola_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            this.CenterToScreen();
        }

        private void tbxParola_TextChanged(object sender, EventArgs e)
        {
            
               
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           // string par = tbxParola.Text;
            if (tbxParola.Text.Equals("hmx952"))
            {
                InterfataServicii inter = new InterfataServicii();
                inter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola introdusa nu este corecta. Incercati din nou.");
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
