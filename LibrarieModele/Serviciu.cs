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
        public int durata, pret, Id_Ser;
        private const int ID_SER = 0;
        private const int NUMESERVICIU = 1;
        private const int DURATA = 2;
        private const int PRET = 3;
        private const int TIP_TUNSOARE = 4;
        public string NumeServiciu { get; set; }
        public int Durata { get; set; }
        public int Pret { get; set; }
        public TipTunsoare TipTunsoare { get; set; }
        public Serviciu(int Id_Ser, string NumeServiciu, int Durata, int Pret, int tip)
        {
            this.Id_Ser = Id_Ser;
            this.NumeServiciu = NumeServiciu;
            this.Durata = Durata;
            this.Pret = Pret;
            this.TipTunsoare = (TipTunsoare)tip;

        }
        public Serviciu()
        {

        }

        public string Info()
        {
            string info = string.Format("Id Serviciu: {0} Nume Serviciu:{0} Durata:{1}",
                            (Id_Ser.ToString() ?? "NECUNOSCUT"),
                            (NumeServiciu ?? "NECUNOSCUT"),
                             (Durata.ToString() ?? "NECUNOSCUT"),
                             (Pret.ToString() ?? "NECUNOSCUT"),
                             (TipTunsoare.ToString() ?? "NECUNOSCUT"));
            return info;
        }

        public override string ToString()
        {
            string info = string.Format("Id serviciu: {0} Nume Serviciu:{1} Durata (minute):{2} Pret (lei):{3} Tip tunsoare: {4}",
                            (Id_Ser.ToString() ?? "NECUNOSCUT"),
                            (NumeServiciu ?? "NECUNOSCUT"),
                             (Durata.ToString() ?? "NECUNOSCUT"),
                             (Pret.ToString() ?? "NECUNOSCUT"),
                             (TipTunsoare.ToString() ?? "NECUNOSCUT"));
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectServiciiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER,
                (Id_Ser.ToString() ?? "NECUNOSCUT"),
                (NumeServiciu ?? "NECUNOSCUT"),
                 (Durata.ToString() ?? "NECUNOSCUT"),
                 (Pret.ToString() ?? "NECUNOSCUT"),
                 (TipTunsoare.ToString() ?? "NECUNOSCUT"));
            return obiectServiciiPentruFisier;

        }
        public Serviciu(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Id_Ser = Convert.ToInt32(dateFisier[ID_SER]);
            NumeServiciu = dateFisier[NUMESERVICIU];
            Console.WriteLine(dateFisier[DURATA]);
            Durata = Convert.ToInt32(dateFisier[DURATA]);
            Pret = Convert.ToInt32(dateFisier[PRET]);
            TipTunsoare = (TipTunsoare)Convert.ToInt32(dateFisier[TIP_TUNSOARE]);

        }
        public bool CautareDupaNume(string NumeComplet)
        {

            if (NumeComplet.ToUpper().CompareTo(NumeComplet.ToUpper()) == 0)
                return true;
            return false;
        }


    }
}
