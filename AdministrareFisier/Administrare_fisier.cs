using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace AdministrareFisier
{
    public class Administrare_fisier
    {
        public class Administrare_FisierText
        {
            private const int NR_MAX_ANGAJATI = 50;
            private string numeFisier;

            public Administrare_FisierText(string numeFisier)
            {
                this.numeFisier = numeFisier;
                Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                streamFisierText.Close();
            }

            public void AddAngajat(Angajat angajat)
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine(angajat.ConversieLaSir_PentruFisier());
                }
            }
            public Angajat[] GetAngajat(out int nrAngajat)
            {
                Angajat[] angajat= new Angajat[NR_MAX_ANGAJATI];
                using (StreamReader stream = new StreamReader(numeFisier))
                {
                    string linieFisier;
                    nrAngajat = 0;
                    while ((linieFisier = stream.ReadLine()) != null)
                    {
                        string[] items= linieFisier.Split(Angajat.SEPARATOR_SECUNDAR_FISIER);
                        int ID, Salariu;
                        DateTime DataAngajarii;
                        Int32.TryParse(items[0], out ID);
                        Int32.TryParse(items[4], out Salariu);
                        DateTime data = DateTime.ParseExact(items[6], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                        if (items.Length != 6)
                        {
                            Console.WriteLine("Numarul de elemente nu corespunde la linia {" + linieFisier + "}.");
                        }
                        else
                        {
                            angajat[nrAngajat++] = new Angajat(ID, items[1], items[2], items[3], Salariu, items[5], data);
                        }
                    }

                }
                return angajat;
            }
        }
    }
}
