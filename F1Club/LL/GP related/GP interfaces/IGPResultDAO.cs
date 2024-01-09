using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LL
{
    public interface IGPResultDAO
    {
        void SetGPResult(GPResult gpResult);
        List<GPResult> GetAllGPResults();
        void DeleteGPResult(int gpid, int driverid);
        void UpdateGPResult(GPResult gpResult);
    }
}
