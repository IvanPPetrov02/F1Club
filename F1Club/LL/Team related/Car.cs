using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Team_related
{
    public class Car
    {
        public int ID { get; set; }
        public Team Team { get; set; }
        public DateOnly SeasonUsed { get; set; }
        public string Chassis { get; set; }
        public string Engine { get; set; }
        public double HandlingScore { get; set; }
        public double AccelerationScore { get; set; }
        public double BreakingScore { get; set; }
        public int TopSpeedPossible { get; set; }

        public Car(int id, Team team, DateOnly seasonUsed, string chassis, string engine, double handlingScore, double accelerationScore, double breakingScore, int topSpeedPossible)
        {
            ID = id;
            Team = team;
            SeasonUsed = seasonUsed;
            Chassis = chassis;
            Engine = engine;
            HandlingScore = handlingScore;
            AccelerationScore = accelerationScore;
            BreakingScore = breakingScore;
            TopSpeedPossible = topSpeedPossible;
        }
    }
}
