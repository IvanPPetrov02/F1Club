using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeGPResultDAO : IGPResultDAO
    {
        private List<GPResult> gpResults = new List<GPResult>();

        public void DeleteGPResult(int gpid, int driverid)
        {
            gpResults.RemoveAll(gr => gr.GP.ID == gpid && gr.Driver.ID == driverid);
        }

        public List<GPResult> GetAllGPResults()
        {
            return gpResults;
        }

        public void SetGPResult(GPResult gpResult)
        {
            gpResults.Add(gpResult);
        }

        public void UpdateGPResult(GPResult gpResult)
        {
            var existingResult = gpResults.FirstOrDefault(gr => gr.GP.ID == gpResult.GP.ID && gr.Driver.ID == gpResult.Driver.ID);
            if (existingResult != null)
            {
                gpResults.Remove(existingResult);
                gpResults.Add(gpResult);
            }
        }
    }

}
