using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public int? CurrentConstructorPoints { get; set; }
        public int? CurrentConstructorWins { get; set; }
        public int? AllTimeConstructorWins { get; set; }

        public Team(int iD, string name, DateOnly creationDate, int? currentConstructorPoints, int? currentConstructorWins, int? allTimeConstructorWins)
        {
            ID = iD;
            Name = name;
            CreationDate = creationDate;
            CurrentConstructorPoints = currentConstructorPoints;
            CurrentConstructorWins = currentConstructorWins;
            AllTimeConstructorWins = allTimeConstructorWins;
        }

        public Team(int iD, string name, DateOnly creationDate)
        {
            ID = iD;
            Name = name;
            CreationDate = creationDate;
        }

        public Team()
        {
        }
    }
}
