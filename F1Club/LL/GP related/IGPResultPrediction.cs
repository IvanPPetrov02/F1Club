using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.GP_related
{
    public interface IGPResultPrediction
    {
        List<Driver> PredictPodium(List<Driver> drivers);
    }
}
