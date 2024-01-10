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
