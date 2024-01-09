using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ICampionshipDAO
    {
        bool AddChampionship(Championship championship);
        bool UpdateChampionship(Championship championship);
        bool DeleteChampionship(int id);
        ChampionshipDTO GetChampionship(int id);
        List<ChampionshipDTO> GetChampionships();
    }
}
