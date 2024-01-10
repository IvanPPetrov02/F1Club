using LL.Team_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.GP_related
{
    public class RacePredictionAlgorithm
    {
        private List<Car> cars;
        private List<GPResult> pastRaceResults;

        public RacePredictionAlgorithm(List<Car> cars, List<GPResult> pastRaceResults)
        {
            this.cars = cars;
            this.pastRaceResults = pastRaceResults;
        }

        public List<(Driver driver, int predictedPosition)> PredictPodium(GP gp, List<GPResult> pastResults, List<Car> cars, List<Driver> drivers)
        {
            var driverScores = new Dictionary<Driver, double>();

            foreach (var driver in drivers)
            {
                double score = 0;
                var car = cars.FirstOrDefault(c => c.Team.ID == driver.Team.ID);
                if (car != null)
                {
                    score += EvaluateDriverHistoricalPerformance(car, gp.Circuit, pastResults);
                    score += EvaluateCarPerformance(car, gp.Circuit);
                }
                score += EvaluateTeamPerformance(driver, pastResults);
                driverScores[driver] = score;
            }

            var sortedDrivers = driverScores.OrderByDescending(kv => kv.Value)
                                            .Select((entry, index) => (entry.Key, predictedPosition: index + 1))
                                            .ToList();

            return sortedDrivers.GetRange(0, 3);
        }


        private double EvaluateCarPerformance(Car car, Circuit circuit)
        {
            if (car == null) return 0;

            double handlingWeight = circuit.NumberOfCorners * circuit.RoadScore;
            double speedWeight = (circuit.Length / 100);

            double score = car.HandlingScore * handlingWeight +
                           car.TopSpeedPossible * speedWeight +
                           car.AccelerationScore +
                           car.BreakingScore * circuit.NumberOfCorners;

            return score;
        }


        private double EvaluateTeamPerformance(Driver driver, List<GPResult> pastResults)
        {
            var teamResults = pastResults.Where(r => r.Driver.Team.ID == driver.Team.ID);
            if (!teamResults.Any()) return 0;

            double averagePosition = teamResults.Average(r => r.Place);
            double score = 0;

            if (averagePosition <= 2)
            {
                score += 15;
            }
            else if (averagePosition <= 5)
            {
                score += 10;
            }
            else if (averagePosition <= 10)
            {
                score += 5;
            }
            else
            {
                score += 2;
            }

            return score;
        }



        private double EvaluateDriverHistoricalPerformance(Car car, Circuit circuit, List<GPResult> pastResults)
        {
            var driverResults = pastResults.Where(r => r.Driver.Team.ID == car.Team.ID && r.GP.Circuit.ID == circuit.ID);
            double score = 0;

            foreach (var result in driverResults)
            {
                switch (result.Place)
                {
                    case 1:
                        score += 25;
                        break;
                    case 2:
                        score += 18;
                        break;
                    case 3:
                        score += 15;
                        break;
                    case 4:
                        score += 12;
                        break;
                    case 5:
                        score += 10;
                        break;
                    case 6:
                        score += 8;
                        break;
                    case 7:
                        score += 6;
                        break;
                    case 8:
                        score += 4;
                        break;
                    case 9:
                        score += 2;
                        break;
                    case 10:
                        score += 1;
                        break;
                    default:
                        score += 0;
                        break;
                }
            }

            return score;
        }
    }
}
