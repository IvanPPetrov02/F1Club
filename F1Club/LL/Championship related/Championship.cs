using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Championship_related
{
    public class Championship
    {
        public int Year { get; set; }
        public Driver? Champion { get; set; }
        public Team? ChampionTeam { get; set; }
        public List<(int Position, Driver driver)> EndPositions { get; set; }
        public List<(int Position, Team team)> EndTeamPositions { get; set; }
        public List<GP> GPs { get; set; }

        public Championship(int year, Driver? champion, Team? championTeam, List<(int Position, Driver driver)> endPositions, List<(int Position, Team team)> endTeamPositions, List<GP> gPs)
        {
            Year = year;
            Champion = champion;
            ChampionTeam = championTeam;
            EndPositions = endPositions;
            EndTeamPositions = endTeamPositions;
            GPs = gPs;
        }

        public Championship()
        {
        }
    }
}
