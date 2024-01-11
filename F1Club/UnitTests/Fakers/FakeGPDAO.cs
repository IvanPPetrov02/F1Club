using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeGPDAO : IGPDAO
    {
        private int lastInsertedId;
        private List<GP> gps = new List<GP>();

        public void CreateGP(GP gp)
        {
            lastInsertedId++;
            gp.ID = lastInsertedId;
            gps.Add(gp);
        }

        public int GetLastInsertedId()
        {
            return lastInsertedId;
        }

        public void DeleteGP(int id)
        {
            gps.RemoveAll(g => g.ID == id);
        }

        public List<GP> GetAllGPs()
        {
            return gps;
        }

        public void UpdateGP(GP gp)
        {
            var existingGP = gps.FirstOrDefault(g => g.ID == gp.ID);
            if (existingGP != null)
            {
                gps.Remove(existingGP);
                gps.Add(gp);
            }
        }
    }

}
