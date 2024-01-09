using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IChampionshipManager
    {
        bool CreateChampionship(Championship Championship);
        bool DeleteChampionship(Championship Championship);
        bool UpdateChampionship(Championship Championship);
        Championship GetChampionshipByID(int id);
        List<Championship> GetAllChampionships();
    }
}
