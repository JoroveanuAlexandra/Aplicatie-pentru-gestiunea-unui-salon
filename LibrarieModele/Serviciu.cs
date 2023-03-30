using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
        public class Serviciu
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        public string nume_serviciu;
        public int durata, pret;
        private const int NUMESERVICIU = 0;
        private const int DURATA = 1;
        private const int PRET = 2;

        public string NumeServiciu { get; set; }
        public int Durata { get; set; }
        public int Pret { get; set; }
        public Serviciu( string NumeServiciu, int Durata, int Pret)
        {
            this.NumeServiciu = NumeServiciu;
            this.Durata = Durata;
            this.Pret = Pret;

        }
        public string Info()
        {
            string info = string.Format("Nume Serviciu:{0} Durata:{1}",
                            (NumeServiciu ?? "NECUNOSCUT"),
                             (Durata.ToString() ?? "NECUNOSCUT"),
                             (Pret.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public override string ToString()
        {
            string info = string.Format("Nume Serviciu:{0} Durata:{1}",
                            (NumeServiciu ?? "NECUNOSCUT"),
                             (Durata.ToString() ?? "NECUNOSCUT"),
                             (Pret.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectServiciiPentruFisier = string.Format("{1}{0}{2}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (NumeServiciu ?? "NECUNOSCUT"),
                 (Durata.ToString() ?? "NECUNOSCUT"),
                 (Pret.ToString() ?? "NECUNOSCUT"));            
            return obiectServiciiPentruFisier;

        }
        public Serviciu (string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            NumeServiciu = dateFisier[NUMESERVICIU];
            Durata = Convert.ToInt32(dateFisier[DURATA]);
            Pret = Convert.ToInt32(dateFisier[PRET]);
          
        }

    }
}
