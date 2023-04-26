using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Angajat
    {

        public static char SEPARATOR_PRINCIPAL_FISIER = ';';
        public static char SEPARATOR_SECUNDAR_FISIER = '/';
        private const int ID_ANGAJAT = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int SALARIU = 4;
        private const int FUNCTIE = 3;
        private const int NR_TELEFON = 6;
        private const int DATA_AN = 5;
        private const int TIP_ANGAJAT = 7;
        public int ID_AN { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumeComplet
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }
        public int Salariu { get; set; }
        public string Functie { get; set; }
        public string Nr_Telefon { get; set; }
        public DateTime DataAngajarii { get; set; }
        public TipAngajat TipAngajat { get; set; }

        public Angajat()
        {

        }
        public Angajat(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID_AN = Convert.ToInt32(dateFisier[ID_ANGAJAT]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            Functie = dateFisier[FUNCTIE];
            Console.WriteLine(dateFisier[SALARIU]);
            Salariu = Convert.ToInt32(dateFisier[SALARIU]);
            Nr_Telefon = dateFisier[NR_TELEFON];
            Console.WriteLine(dateFisier[DATA_AN]);
            DataAngajarii = Convert.ToDateTime(dateFisier[DATA_AN].Split(' ')[0]);
            TipAngajat = (TipAngajat)Convert.ToInt32(dateFisier[TIP_ANGAJAT]);
        }
        public Angajat(int ID_AN, string Nume, string Prenume, string Functie, int Salariu, string Nr_Telefon, DateTime DataAngajarii, int tipA)

        {
            this.ID_AN = ID_AN;
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Functie = Functie;
            this.Salariu = Salariu;
            this.Nr_Telefon = Nr_Telefon;
            this.DataAngajarii = DataAngajarii;
            this.TipAngajat = (TipAngajat)tipA;
        }

        public string Info()
        {
            string info = string.Format("ID_Angajat:{0} Nume:{1} Prenume:{2} Functie: {3} Salariu:{4} Data_angajarii {5} Numar_telefon:{6} Tip angajat:{7}",
                   ID_AN.ToString(),
                   (Nume ?? "NECUNOSCUT"),
                   (Prenume ?? "NECUNOSCUT"),
                   (Functie ?? "NECUNOSCUT"),
                   (Salariu.ToString() ?? "NECUNOSCUT"),
                   (DataAngajarii.ToString() ?? "NECUNOSCUT"),
                   (Nr_Telefon ?? "NECUNOSCUT"),
                   (TipAngajat.ToString() ?? "NECUNOSCUT"));


            return info;
        }
        public override string ToString()
        {
            string info = string.Format("ID_Angajat:{0} Nume:{1} Prenume:{2} Functie: {3} Salariu:{4} Data_angajarii {5} Numar_telefon:{6} Tip angajat:{7}",
                   ID_AN.ToString(),
                   (Nume ?? "NECUNOSCUT"),
                   (Prenume ?? "NECUNOSCUT"),
                   (Functie ?? "NECUNOSCUT"),
                   (Salariu.ToString() ?? "NECUNOSCUT"),
                   (DataAngajarii.ToString() ?? "NECUNOSCUT"),
                   (Nr_Telefon ?? "NECUNOSCUT"),
                   (TipAngajat.ToString() ?? "NECUNOSCUT"));


            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectAngajatiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID_AN.ToString(),
                            (Nume ?? "NECUNOSCUT"),
                            (Prenume ?? "NECUNOSCUT"),
                            (Functie ?? "NECUNOSCUT"),
                            (Salariu.ToString() ?? "NECUNOSCUT"),
                            (DataAngajarii.ToString() ?? "NECUNOSCUT"),
                            (Nr_Telefon.ToString() ?? "NECUNOSCUT"),
                            (Convert.ToInt32(TipAngajat).ToString() ?? "NECUNOSCUT"));

            return obiectAngajatiPentruFisier;

        }
        public bool CautareDupaNume(string NumeComplet)
        {

            if (NumeComplet.ToUpper().CompareTo(NumeComplet.ToUpper()) == 0)
                return true;
            return false;
        }
    }
}
