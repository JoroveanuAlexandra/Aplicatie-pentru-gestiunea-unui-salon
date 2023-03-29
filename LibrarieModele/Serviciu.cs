using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    class Serviciu
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        public string nume_serviciu;
        public int durata;
        public string NumeServiciu { get; set; }
        public int Durata { get; set; }

    }
}
