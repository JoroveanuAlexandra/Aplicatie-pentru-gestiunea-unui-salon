using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using  NivelStocare;
using System.Windows.Forms;

namespace Aplicatie_salon
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajat angajat = new Angajat();
            Serviciu serviciu = new Serviciu();
            string numeFisier = "date1.txt";
            string numeFisier2 = "date2.txt";
            //  string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareFisierText adminAngajat = new AdministrareFisierText(numeFisier);
            AdministrareFisierText adminServiciu = new AdministrareFisierText(numeFisier2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());

            List<Angajat> SALON = new List<Angajat>();
            List<Serviciu> SERVICIU = new List<Serviciu>();
            int nrAngajat = 0;
            int nrServiciu = 0;
            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii angajat: ");
                Console.WriteLine("A. Afisare angajat: ");
                Console.WriteLine("F. Afisare angajat din fisier: ");
                Console.WriteLine("S. Salvare angajat in fisier: ");
                Console.WriteLine("C. Cautare angajat dupa nume: ");
                Console.WriteLine("J. Introducere informatii serviciu: ");
                Console.WriteLine("K. Afisare serviciu: ");
                Console.WriteLine("L. Afisare serviciu din fisier: ");
                Console.WriteLine("M. Salvare serviciu in fisier: ");
                Console.WriteLine("N. Cautare serviciu: ");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine().Trim();

                switch (optiune.ToUpper())
                {
                    case "I":
                        int idAngajati = nrAngajat + 1;
                        Console.WriteLine("Introdu numele angajatului {0}:", idAngajati);
                        string Nume = Console.ReadLine();
                        Console.WriteLine("Introdu prenumele angajatului {0}: ", idAngajati);
                        string Prenume = Console.ReadLine();
                        Console.WriteLine("Introdu functia angajatului {0}:");
                        Console.WriteLine("0-coafor\n" +
                                           "1-cosmetica\n" +
                                           "2-manichiura\n" +
                                           "3-manager\n");
                        int TipF = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introdu numarul de telefon al angajatului {0}:", idAngajati);
                        string Nr_Telefon = Console.ReadLine();
                        Console.WriteLine("Introdu salariul angajatului {0}:", idAngajati);
                        int Salariu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introdu data angajarii angajatului {0}:", idAngajati);
                        string data = Console.ReadLine();
                        DateTime DataAngajarii = DateTime.ParseExact(data, "dd.mm.yyyy", null);
                        angajat = new Angajat(idAngajati, Nume, Prenume, TipF, Salariu, Nr_Telefon, DataAngajarii);
                       
                        SALON.Add(angajat);

                        break;
                    case "A":
                        Console.WriteLine(string.Join("\n", SALON));
                        /*for (int i = 0; i < SALON.Count; i++)
                        {
                            Console.WriteLine(SALON[i].Info());
                        }
                        */
                        break;
                    case "F":
                       // SALON = adminAngajat.GetAngajat(out nrAngajat);
                        Console.WriteLine(string.Join("\n", SALON));
                        break;
                    case "S":
                        idAngajati = nrAngajat + 1;
                        nrAngajat++;
                        for (int i = 0; i < SALON.Count; i++)
                        {
                            adminAngajat.AddAngajat(SALON[i]);
                        }

                        break;
                    case "C":
                        Console.WriteLine("Ce angajat doriti sa cautati? (Nume complet) ");
                        string nume=Console.ReadLine();
                        for(int i=0;i<SALON.Count; i++)
                        {
                            if(SALON[i].CautareDupaNume(nume) == true)
                            {
                                Console.WriteLine("Angajatul a fost gasit");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }    
                        break;
                    case "J":
                        int idServiciu = nrServiciu + 1;
                        Console.WriteLine("Introdu numele serviciului {0}:", idServiciu);
                        string NumeServiciu = Console.ReadLine();
                        Console.WriteLine("Introdu durata serviciului (minute) {0}: ", idServiciu);
                        int Durata = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introdu pretul serviciului (lei) {0}:", idServiciu);
                        int Pret = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduceti tipul serviciului:");
                        Console.WriteLine("0-bob lung\n" +
                            "1-bob scurt\n" +
                            "2-scari\n" +
                            "3-cu breton=3\n" +
                            "4-in straturi=4\n" +
                            "5-pixie\n");
                        int TipS = Convert.ToInt32(Console.ReadLine());
                        serviciu = new Serviciu(idServiciu, NumeServiciu, Durata, Pret, TipS);
                        SERVICIU.Add(serviciu);
                        break;
                    case "K":
                        Console.WriteLine(string.Join("\n", SERVICIU));
                        break;
                    case "L":
                        SERVICIU = adminServiciu.GetServiciu(out nrServiciu);
                        Console.WriteLine(string.Join("\n", SERVICIU));
                        break;
                    case "M":
                        idServiciu = nrServiciu + 1;
                        nrServiciu++;
                        for (int i = 0; i < SERVICIU.Count; i++)
                        {
                            adminServiciu.AddServiciu(SERVICIU[i]);
                        }
                        break;
                    case "N":
                        Console.WriteLine("Ce serviciu cautati? ");
                        string numeser = Console.ReadLine();
                        for (int i = 0; i < SERVICIU.Count; i++)
                        {
                            if (SERVICIU[i].CautareDupaNume(numeser) == true)
                            {
                                Console.WriteLine("Serviciul a fost gasit");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }


            } while (optiune.ToUpper() != "X");

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
                angajat[contor].TipFunctie.ToString() ?? "NECUNOSCUT",
                angajat[contor].Salariu.ToString() ?? "NECUNOSCUT",
                angajat[contor].DataAngajarii.ToString() ?? "NECUNOSCUT",
                angajat[contor].Nr_Telefon.ToString() ?? "NECUNOSCUT");
                Console.WriteLine(infoAngajat);
            }
        }
        public static void AfisareServicii(Serviciu[] serviciu, int nrServiciu)
        {
            Console.WriteLine("Serviciile sunt:");
            for (int contor = 0; contor < nrServiciu; contor++)
            {
                string infoAngajat = string.Format("Serviciul cu id-ul #{0} are numele {1}, durata {2} si pretul {3}",
                serviciu[contor].Id_Ser,
                serviciu[contor].NumeServiciu ?? "NECUNOSCUT",
                serviciu[contor].Durata.ToString() ?? "NECUNOSCUT",
                serviciu[contor].Pret.ToString() ?? "NECUNOSCUT");
                Console.WriteLine(infoAngajat);


            }
        }

    }
}
