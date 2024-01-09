using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class GPResult
    {
        public GP GP { get; set; }
        public int Place { get; set; }
        public Driver Driver { get; set; }
        public TimeSpan LapTime { get; set; }
        public TimeSpan FinishTime { get; set; }
        public int MaxSpeed { get; set; }
        public int AvgSpeed { get; set; }


        public GPResult(GP gP, int place, Driver driver, TimeSpan lapTime, TimeSpan finishTime, int maxSpeed, int avgSpeed)
        {
            GP = gP;
            Place = place;
            Driver = driver;
            LapTime = lapTime;
            FinishTime = finishTime;
            MaxSpeed = maxSpeed;
            AvgSpeed = avgSpeed;
        }

        public GPResult()
        {
        }
    }
}
