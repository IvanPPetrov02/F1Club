using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Championship
    {
        public int ID { get; set; }
        public DateOnly Season { get; set; }
        public Driver? Winner { get; set; }
        public Team? ConstructorWinner { get; set; }
        public List<GP>? GPs { get; set; }

        public Championship(int iD, DateOnly season, Driver? winner, Team? constructorWinner, List<GP>? gps)
        {
            ID = iD;
            Season = season;
            Winner = winner;
            ConstructorWinner = constructorWinner;
            GPs = gps;
        }

        public Championship(int iD, DateOnly season)
        {
            ID = iD;
            Season = season;
        }

        public Championship()
        {
        }
    }
}
