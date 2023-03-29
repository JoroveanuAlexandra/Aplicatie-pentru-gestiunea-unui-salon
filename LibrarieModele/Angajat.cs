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
        public int ID_AN { get; set; } = 0;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Salariu { get; set; }
        public string Functie{ get; set; }
        public string Nr_Telefon { get; set; }
        public DateTime DataAngajarii { get; set; }

        public Angajat()
        {

        }
        public Angajat(int ID_AN, string Nume, string Prenume, string Functie, int Salariu, string Nr_Telefon, DateTime DataAngajarii)
        {
            this.ID_AN = ID_AN;
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Functie = Functie;
            this.Salariu = Salariu;
            this.Nr_Telefon = Nr_Telefon;
            this.DataAngajarii = DataAngajarii;
        }

        public string Info()
        {
            string info = string.Format("ID_Angajat:{0} Nume:{1} Prenume:{2} Functie: {3} Salariu:{4} Data_angajarii {5} Numar_telefon:{6}",
                            ID_AN.ToString(),
                            (Nume ?? "NECUNOSCUT"),
                             (Prenume ?? "NECUNOSCUT"),
                             (Functie ?? "NECUNOSCUT"),
                             (Salariu.ToString() ?? "NECUNOSCUT"),
                             (DataAngajarii.ToString() ?? "NECUNOSCUT"),
                              (Nr_Telefon ?? "NECUNOSCUT"));
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectAngajatiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID_AN.ToString(),
                            (Nume ?? "NECUNOSCUT"),
                             (Prenume ?? "NECUNOSCUT"),
                             (Functie ?? "NECUNOSCUT"),
                             (Salariu.ToString() ?? "NECUNOSCUT"),
                             (DataAngajarii.ToString() ?? "NECUNOSCUT"),
                              (Nr_Telefon.ToString() ?? "NECUNOSCUT"));
            return obiectAngajatiPentruFisier;

        }

    }
}
