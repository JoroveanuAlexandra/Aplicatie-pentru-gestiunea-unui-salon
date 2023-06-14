using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;

namespace NivelStocare
{
    class IStocareDate
    {
    }
    public interface IStocareData
    {
        void AddProgramare(Programare s);
        List<Programare> GetProgramare();
        Programare GetProgramare(string nume_client, string angajat, DateTime data_start, string serviciu);
        Programare GetProgramare(int idProgramare);
        bool UpdateProgramare(Programare p);
    }
}
