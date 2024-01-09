using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IChampionshipResultManager
    {
        bool SetChampionshipResult(ChampionshipResults ChampionshipResult);
        bool UpdateChampionshipResult(ChampionshipResults ChampionshipResult);
        bool RemoveChampionshipResult(ChampionshipResults ChampionshipResult);
        ChampionshipResults GetChampionshipResultByChampionship(int id);
        List<ChampionshipResults> GetAllChampionshipResults();
    }
}
