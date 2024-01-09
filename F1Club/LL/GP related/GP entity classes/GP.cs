using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class GP
    {
        public int ID { get; set; }
        public Circuit Circuit { get; set; }
        public DateOnly DateOfGP { get; set; }

        public GP(int iD, Circuit circuit, DateOnly dateOfGP)
        {
            ID = iD;
            Circuit = circuit;
            DateOfGP = dateOfGP;
        }

        public GP()
        {
        }
    }
}
