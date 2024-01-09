using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class ChampionshipResults
    {
        public Championship Championship { get; set; }
        public int Place { get; set; }
        public Driver Driver { get; set; }

        public ChampionshipResults(Championship championship, int place, Driver driver)
        {
            Championship = championship;
            Place = place;
            Driver = driver;
        }

        public ChampionshipResults()
        {
        }
    }
}
