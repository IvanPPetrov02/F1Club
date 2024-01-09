using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class ChampionshipDTO
    {
        public int ID { get; set; }
        public DateOnly Season { get; set; }
        public int? Winner { get; set; }
        public int? ConstructorWinner { get; set; }
        public List<int>? GPs { get; set; }

        public ChampionshipDTO(int iD, DateOnly season, int? winner, int? constructorWinner, List<int>? gps)
        {
            ID = iD;
            Season = season;
            Winner = winner;
            ConstructorWinner = constructorWinner;
            GPs = gps;
        }

        public ChampionshipDTO()
        {
        }
    }
}
