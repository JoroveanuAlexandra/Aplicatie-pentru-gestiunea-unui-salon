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
            private const int NR_MAX_SERVICII = 50;
            private string numeFisier;
            // private string numeFisierServicii;

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
            public List<Angajat> GetAngajat(out int nrAngajat)
            {
                Angajat[] angajat = new Angajat[NR_MAX_ANGAJATI];
                using (StreamReader stream = new StreamReader(numeFisier, true))
                {
                    string linieFisier;
                    nrAngajat = 0;
                    while ((linieFisier = stream.ReadLine()) != null)
                    {
                        angajat[nrAngajat++] = new Angajat(linieFisier);
                    }

                }
                List<Angajat> ang = new List<Angajat>();
                ang = angajat.ToList();
                return ang;
            }

            public void AddServiciu(Serviciu serviciu)
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier))
                {
                    streamWriterFisierText.WriteLine(serviciu.ConversieLaSir_PentruFisier());
                }
            }
            public List<Serviciu> GetServiciu(out int nrServiciu)
            {
                Serviciu[] serviciu = new Serviciu[NR_MAX_SERVICII];
                using (StreamReader stream = new StreamReader(numeFisier))
                {
                    string linieFisier;
                    nrServiciu = 0;
                    while ((linieFisier = stream.ReadLine()) != null)
                    {
                        serviciu[nrServiciu++] = new Serviciu(linieFisier);
                    }

                }
                List<Serviciu> ser = new List<Serviciu>();
                ser = serviciu.ToList();
                return ser;
            }

        }
    }
}
