using LL;
using LL.GP_related;
using LL.Team_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    [TestClass]
    public class GPPredictAlgorithmTests
    {
        GPPredictionAlgorithm gpPredictionAlgorithm = new GPPredictionAlgorithm();

        private void InitializeMockData(out List<Car> cars, out List<Driver> drivers, out GP gp, out List<GPResult> pastRaceResults, out Circuit circuit)
        {
            circuit = new Circuit(1, "Monaco", 78, 3.337, 19, 8.5);

            var teamAlpha = new Team(1, "Team Alpha", DateOnly.FromDateTime(new DateTime(2000, 1, 1)));
            var teamBeta = new Team(2, "Team Beta", DateOnly.FromDateTime(new DateTime(2005, 1, 1)));

            var carAlpha1 = new Car(1, teamAlpha, DateOnly.FromDateTime(DateTime.Now), "ChassisAlpha1", "EngineAlpha1", 9.5, 8.5, 7.5, 300);
            var carAlpha2 = new Car(2, teamAlpha, DateOnly.FromDateTime(DateTime.Now), "ChassisAlpha2", "EngineAlpha2", 9.0, 8.0, 7.0, 295);
            var carBeta1 = new Car(3, teamBeta, DateOnly.FromDateTime(DateTime.Now), "ChassisBeta1", "EngineBeta1", 8.5, 7.5, 6.5, 290);
            var carBeta2 = new Car(4, teamBeta, DateOnly.FromDateTime(DateTime.Now), "ChassisBeta2", "EngineBeta2", 8.0, 7.0, 6.0, 285);

            cars = new List<Car> { carAlpha1, carAlpha2, carBeta1, carBeta2 };

            var driverAlpha1 = new Driver(1, 77, "John", "Doe", DateOnly.FromDateTime(new DateTime(1985, 1, 1)), teamAlpha);
            var driverAlpha2 = new Driver(2, 78, "Jane", "Roe", DateOnly.FromDateTime(new DateTime(1986, 2, 2)), teamAlpha);
            var driverBeta1 = new Driver(3, 88, "Alice", "Smith", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), teamBeta);
            var driverBeta2 = new Driver(4, 89, "Bob", "Brown", DateOnly.FromDateTime(new DateTime(1991, 2, 2)), teamBeta);

            drivers = new List<Driver> { driverAlpha1, driverAlpha2, driverBeta1, driverBeta2 };

            gp = new GP(1, circuit, DateOnly.FromDateTime(DateTime.Now));

            pastRaceResults = new List<GPResult>
        {
            new GPResult(gp, 1, driverAlpha1, TimeSpan.FromMinutes(120), TimeSpan.FromHours(1.5), 300, 250),
            new GPResult(gp, 2, driverAlpha2, TimeSpan.FromMinutes(121), TimeSpan.FromHours(1.6), 290, 240),
            new GPResult(gp, 3, driverBeta1, TimeSpan.FromMinutes(122), TimeSpan.FromHours(1.7), 280, 230),
            new GPResult(gp, 4, driverBeta2, TimeSpan.FromMinutes(123), TimeSpan.FromHours(1.8), 270, 220)
        };

            gp = new GP(1, circuit, DateOnly.FromDateTime(DateTime.Now));
        }

        [TestMethod]
        public void PredictPodiumTest()
        {
            List<Car> cars;
            List<Driver> drivers;
            GP gp;
            List<GPResult> pastRaceResults;
            Circuit circuit;
            InitializeMockData(out cars, out drivers, out gp, out pastRaceResults, out circuit);

            var predictedPodium = gpPredictionAlgorithm.PredictPodium(gp, pastRaceResults, cars, drivers);

            Assert.IsTrue(predictedPodium.Count <= 3);

            foreach (var (driver, _) in predictedPodium)
            {
                Assert.IsTrue(drivers.Contains(driver));
            }

            var predictedPositions = predictedPodium.Select(p => p.predictedPosition).ToList();
            Assert.AreEqual(predictedPositions.Distinct().Count(), predictedPositions.Count);

            var expectedTopDriver = drivers[0];
            var expectedSecondDriver = drivers[1];
            var expectedThirdDriver = drivers[2];

            Assert.AreEqual(expectedTopDriver.ID, predictedPodium.ElementAtOrDefault(0).driver.ID);
            Assert.AreEqual(expectedSecondDriver.ID, predictedPodium.ElementAtOrDefault(1).driver.ID);
            Assert.AreEqual(expectedThirdDriver.ID, predictedPodium.ElementAtOrDefault(2).driver.ID);
        }

    }
}
