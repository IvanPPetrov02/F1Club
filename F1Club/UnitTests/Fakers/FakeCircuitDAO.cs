using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeCircuitDAO : ICircuitDAO
    {
        private int lastInsertedId;
        private List<Circuit> circuits = new List<Circuit>();

        public void CreateCircuit(Circuit circuit)
        {
            lastInsertedId++;
            circuit.ID = lastInsertedId;
            circuits.Add(circuit);
        }

        public int GetLastInsertedId()
        {
            return lastInsertedId;
        }

        public void DeleteCircuit(int id)
        {
            circuits.RemoveAll(c => c.ID == id);
        }

        public List<Circuit> GetCircuits()
        {
            return circuits;
        }

        public void UpdateCircuit(Circuit circuit)
        {
            var existingCircuit = circuits.FirstOrDefault(c => c.ID == circuit.ID);
            if (existingCircuit != null)
            {
                circuits.Remove(existingCircuit);
                circuits.Add(circuit);
            }
        }
    }
}
