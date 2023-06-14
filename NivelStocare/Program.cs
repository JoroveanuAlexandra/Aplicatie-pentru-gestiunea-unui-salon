using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using System.IO;

namespace NivelStocare
{

    public class AdministrareFisierText

    {
        private const int NR_MAX_ANGAJATI = 50;
        private const int NR_MAX_SERVICII = 50;
        private const int NR_MAX_PROGRAMARI = 50;
        private string numeFisier;
        // private string numeFisierServicii;
        static void Main()
        {

        }
        public AdministrareFisierText(string numeFisier)
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
        public List<Angajat> GetAngajat()
        {
            //Angajat[] angajat = new Angajat[NR_MAX_ANGAJATI];
            List<Angajat> angajati = new List<Angajat>();
            using (StreamReader stream = new StreamReader(numeFisier, true))
            {
                string linieFisier;
               // nrAngajat = 0;
                while ((linieFisier = stream.ReadLine()) != null)
                {
                    //angajat[nrAngajat++] = new Angajat(linieFisier);
                    angajati.Add(new Angajat(linieFisier));
                }

            }
            List<Angajat> ang = new List<Angajat>();
            //ang = angajat.ToList();
            return angajati;
        }

        public void AddServiciu(Serviciu serviciu)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier))
            {
                streamWriterFisierText.WriteLine(serviciu.ConversieLaSir_PentruFisier());
            }
        }
        public void AddProgramare(Programare programare)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier))
            {
                streamWriterFisierText.WriteLine(programare.ConversieLaSir_PentruFisier());
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
        public List<Programare> GetProgramare(out int nrProgramare)
        {
            Programare[] programare = new Programare[NR_MAX_PROGRAMARI];
            using (StreamReader stream = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrProgramare = 0;
                while ((linieFisier = stream.ReadLine()) != null)
                {
                    programare[nrProgramare++] = new Programare(linieFisier);
                }

            }
            List<Programare> prog= new List<Programare>();
            prog = programare.ToList();
            return prog;
        }
    }
}