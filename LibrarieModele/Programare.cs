using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Programare
    {
        private DateTime data_start;
        private string nume_client;
        public Angajat nume_angajat;
        public Serviciu serviciu;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        public int Id_Prog;
        private const int ID_PROG = 0;
        private const int NUMECLIENT = 1;
        private const int NUMEANGAJAT = 2;
        private const int DATA = 3;

        private DateTime Data_Start { get; set; }
        private string Nume_Client { get; set; }
        private Angajat Nume_Angajat { get; set; }
        private Serviciu Serviciu{ get; set; }


        public Programare(DateTime Data_Start, string Nume_Client, Angajat nume_angajat, Serviciu serviciu)
        {
            this.data_start = data_start;
            this.nume_client = nume_client;
            this.nume_angajat = nume_angajat;
            this.serviciu = serviciu;

        }
        public Programare(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Id_Prog = Convert.ToInt32(dateFisier[ID_PROG]);
            Nume_Client = dateFisier[NUMECLIENT];
            //Nume_Angajat = dateFisier[NUMEANGAJAT];
            Console.WriteLine(dateFisier[DATA]);


        }
        public string Info()
        {
            string info = string.Format("Durata serviciu:{0} Nume client:{1} Angajat: {2} Serviciu: {3}",
                            (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (nume_angajat.ToString() ?? "NECUNOSCUT"),
                            (serviciu.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public override string ToString()
        {
            string info = string.Format("Durata serviciu:{0} Nume client:{1} Angajat: {2} Serviciu: {3}",
                            (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (nume_angajat.NumeComplet.ToString() ?? "NECUNOSCUT"),
                            (serviciu.NumeServiciu.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectServiciiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
               (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (nume_angajat.ToString() ?? "NECUNOSCUT"),
                            (serviciu.ToString() ?? "NECUNOSCUT"));
            return obiectServiciiPentruFisier;

        }
    }
}
