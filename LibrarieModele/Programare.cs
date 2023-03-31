using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    class Programare
    {
        private DateTime data_start;
        private string nume_client;
        public Angajat angajat;
        public Serviciu serviciu;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        public Programare(DateTime Data_Start, string Nume_Client, Angajat angajat, Serviciu serviciu)
        {
            this.data_start = data_start;
            this.nume_client = nume_client;
            this.angajat = angajat;
            this.serviciu = serviciu;

        }
        public string Info()
        {
            string info = string.Format("Durata serviciu:{0} Nume client:{1} Angajat: {2} Serviciu: {3}",
                            (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (angajat.ToString() ?? "NECUNOSCUT"),
                            (serviciu.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public override string ToString()
        {
            string info = string.Format("Durata serviciu:{0} Nume client:{1} Angajat: {2} Serviciu: {3}",
                            (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (angajat.ToString() ?? "NECUNOSCUT"),
                            (serviciu.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectServiciiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
               (data_start.ToString() ?? "NECUNOSCUT"),
                             (nume_client.ToString() ?? "NECUNOSCUT"),
                             (angajat.ToString() ?? "NECUNOSCUT"),
                            (serviciu.ToString() ?? "NECUNOSCUT"));
            return obiectServiciiPentruFisier;

        }
    }
}
