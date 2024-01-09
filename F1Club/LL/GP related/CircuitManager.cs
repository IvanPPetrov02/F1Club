using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL.GP_related;

namespace LL.GP_related
{
    public class CircuitManager
    {
        ICircuitDAO circuitDAO;

        public CircuitManager(ICircuitDAO circuitDAO)
        {
            this.circuitDAO = circuitDAO;
        }

        private static List<Circuit>? Circuits = new List<Circuit>();

        private void PopulateIfEmpty()
        {
            if (Circuits.Any())
            {
                return;
            }
            else
            {
                RefreshTeamsFromDatabase();
            }
        }

        private void RefreshTeamsFromDatabase()
        {
            Circuits?.Clear();

            foreach (Circuit circuit in circuitDAO.GetCircuits())
            {
                Circuits.Add(circuit);
            }
        }

        private int GetLastInsertedId()
        {
            try
            {
                return circuitDAO.GetLastInsertedId();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void CreateCircuit(Circuit Circuit)
        {
            try
            {
                circuitDAO.CreateCircuit(Circuit);
                Circuit.ID = GetLastInsertedId();
                Circuits.Add(Circuit);

            }
            catch (Exception)
            {
                return;
            }
        }

        public void DeleteCircuit(int id)
        {
            try
            {
                circuitDAO.DeleteCircuit(id);

                PopulateIfEmpty();
                Circuit circuitToRemove = Circuits?.FirstOrDefault(Circuit => Circuit.ID == id);
                if (circuitToRemove != null)
                {
                    Circuits.Remove(circuitToRemove);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<Circuit>? GetAllCircuitsRefresh()
        {
            PopulateIfEmpty();
            return Circuits.ToList();
        }

        public List<Circuit> GetAllCircuits()
        {
            RefreshTeamsFromDatabase();
            return Circuits;
        }

        public Circuit GetCircuitByID(int id)
        {
            PopulateIfEmpty();
            Circuit circuit = Circuits?.FirstOrDefault(c => c.ID == id);
            return circuit;
        }

        public void UpdateCircuit(Circuit Circuit)
        {
            try
            {
                circuitDAO.UpdateCircuit(Circuit);
                PopulateIfEmpty();
                Circuit existingCircuit = Circuits?.First(c => c.ID == Circuit.ID);
                if (existingCircuit != null)
                {
                    existingCircuit.Name = Circuit.Name;
                    existingCircuit.NumberOfLaps = Circuit.NumberOfLaps;
                    existingCircuit.Length = Circuit.Length;
                    existingCircuit.NumberOfCorners = Circuit.NumberOfCorners;
                    existingCircuit.RoadScore = Circuit.RoadScore;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

    }
}
