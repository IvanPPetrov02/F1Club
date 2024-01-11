using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Circuit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfLaps { get; set; }
        public double Length { get; set; }
        public int NumberOfCorners { get; set; }
        public double RoadScore { get; set; }

        public Circuit(int iD, string name, int numberOfLaps, int length, int numberOfCorners, double roadScore)
        {
            ID = iD;
            Name = name;
            NumberOfLaps = numberOfLaps;
            Length = length;
            NumberOfCorners = numberOfCorners;
            RoadScore = roadScore;
        }

        public Circuit()
        {
        }
    }
}
