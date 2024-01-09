using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ICircuitDAO
    {
        List<Circuit> GetCircuits();
        void CreateCircuit(Circuit circuit);
        void UpdateCircuit(Circuit circuit);
        void DeleteCircuit(int id);
        int GetLastInsertedId();
    }
}
