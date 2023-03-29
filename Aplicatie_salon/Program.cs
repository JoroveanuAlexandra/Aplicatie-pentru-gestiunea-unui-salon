using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using AdministrareFisier;
using static AdministrareFisier.Administrare_fisier;

namespace Aplicatie_salon
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajat angajat = new Angajat();
            string numeFisier = "date1.txt";
            //  string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            Administrare_FisierText adminAngajat = new Administrare_FisierText(numeFisier);
            List<Angajat> SALON = new List<Angajat>();
            int nrAngajat = 0;
            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii angajat: ");
                Console.WriteLine("A. Afisare angajat: ");
                Console.WriteLine("F. Afisare angajat din fisier: ");
                Console.WriteLine("S. Salvare angajat in fisier: ");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine().Trim();

                switch (optiune.ToUpper())
                {
                    case "I":
                        int idAngajati = nrAngajat + 1;
                        Console.WriteLine("Introdu numele angajatului {0}:", idAngajati);
                        string Nume = Console.ReadLine();
                        Console.WriteLine("Introdu prenumele angajatului: {0}", idAngajati);
                        string Prenume = Console.ReadLine();
                        Console.WriteLine("Introdu functia angajatului: {0}", idAngajati);
                        string Functia = Console.ReadLine();
                        Console.Write("Introdu numarul de telefon al angajatului: {0}", idAngajati);
                        string Nr_Telefon = Console.ReadLine();
                        Console.WriteLine("Introdu salariul angajatului: {0}", idAngajati);
                        int Salariu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introdu data angajarii angajatului: {0}", idAngajati);
                        string data = Console.ReadLine();
                        DateTime DataAngajarii = DateTime.ParseExact(data, "yyyy-MM-dd", null);

                        angajat = new Angajat(idAngajati, Nume, Prenume, Functia, Salariu, Nr_Telefon, DataAngajarii);
                        SALON.Add(angajat);
                        nrAngajat++;

                        break;
                    case "A":

                        for (int i = 0; i < SALON.Count; i++)
                        {
                            Console.WriteLine(SALON[i].Info());
                        }
                        break;
                    case "F":
                        Angajat[] angajati = adminAngajat.GetAngajat(out nrAngajat);
                        AfisareAngajati(angajati, nrAngajat);
                        break;
                    case "S":
                        idAngajati = nrAngajat + 1;
                        nrAngajat++;
                        for (int i = 0; i < SALON.Count; i++)
                        {
                            adminAngajat.AddAngajat(SALON[i]);
                        }

                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }


                } while (optiune.ToUpper() != "X") ;

                Console.ReadKey();
            }

        public static void AfisareAngajati(Angajat[] angajat, int nrAngajat)
        {
            Console.WriteLine("Angajatii sunt:");
                for (int contor = 0; contor < nrAngajat; contor++)
                {
                    string infoAngajat = string.Format("Angajatul cu id-ul #{0} are numele {1}, prenumele {2},functia {3},, salariul {4}, s-a angajat la data {5} si are numarul de telefon {7}.",
                    angajat[contor].ID_AN,
                    angajat[contor].Nume ?? "NECUNOSCUT",
                    angajat[contor].Prenume ?? "NECUNOSCUT",
                    angajat[contor].Functie ?? "NECUNOSCUT",
                    angajat[contor].Salariu.ToString() ?? "NECUNOSCUT",
                    angajat[contor].DataAngajarii.ToString() ?? "NECUNOSCUT",
                    angajat[contor].Nr_Telefon.ToString() ?? "NECUNOSCUT");
                    Console.WriteLine(infoAngajat);


                }
        }
        
    }
}
