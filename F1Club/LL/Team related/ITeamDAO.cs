using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ITeamDAO
    {
        void CreateTeam(Team team);
        void DeleteTeam(int id);
        void UpdateTeam(Team team);
        List<Team> GetAllTeams();
        int GetLastInsertedId();
    }
}
