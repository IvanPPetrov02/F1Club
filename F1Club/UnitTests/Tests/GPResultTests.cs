using LL;
using LL.GP_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Fakers;

namespace UnitTests.Tests
{
    [TestClass]
    public class GPResultTests
    {
        GPResultManager gpResultManager = new GPResultManager(new FakeGPResultDAO());

        [TestMethod]
        public void SetGPResultTest()
        {
            var circuit = new Circuit(1, "Test Circuit", 50, 5.8, 20, 9.5);
            var gp = new GP(0, circuit, DateOnly.FromDateTime(DateTime.Now));

            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(DateTime.Now));
            var driver = new Driver(1, 25, "John", "Doe", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);

            var gpResult = new GPResult(gp, 1, driver, TimeSpan.FromSeconds(100), TimeSpan.FromMinutes(60), 200, 150);
            var gpResults = new List<GPResult> { gpResult };

            gpResultManager.SetGPResult(gpResults);
            var results = gpResultManager.GetAllGPResults();

            Assert.IsTrue(results.Contains(gpResult));
        }


        [TestMethod]
        public void DeleteGPResultTest()
        {
            var circuit = new Circuit(2, "Another Circuit", 60, 6.2, 22, 8.9);
            var gp = new GP(1, circuit, DateOnly.FromDateTime(DateTime.Now));

            var team = new Team(2, "Team Beta", DateOnly.FromDateTime(DateTime.Now));
            var driver = new Driver(2, 33, "Alice", "Smith", DateOnly.FromDateTime(new DateTime(1992, 4, 23)), team);

            var gpResult = new GPResult(gp, 2, driver, TimeSpan.FromSeconds(105), TimeSpan.FromMinutes(62), 195, 148);
            gpResultManager.SetGPResult(new List<GPResult> { gpResult });

            gpResultManager.DeleteGPResult(gpResult);
            var results = gpResultManager.GetAllGPResults();

            Assert.IsFalse(results.Contains(gpResult));
        }

        [TestMethod]
        public void UpdateGPResultTest()
        {
            var circuit = new Circuit(1, "Test Circuit", 50, 5.8, 20, 9.5);
            var gp = new GP(0, circuit, DateOnly.FromDateTime(DateTime.Now));

            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(DateTime.Now));
            var driver = new Driver(1, 25, "John", "Doe", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);

            var gpResult = new GPResult(gp, 1, driver, TimeSpan.FromSeconds(100), TimeSpan.FromMinutes(60), 200, 150);
            gpResultManager.SetGPResult(new List<GPResult> { gpResult });

            gpResult.LapTime = TimeSpan.FromSeconds(95);
            gpResult.FinishTime = TimeSpan.FromMinutes(58);

            gpResultManager.UpdateGPResult(new List<GPResult> { gpResult });
            var updatedResults = gpResultManager.GetAllGPResults().FirstOrDefault();

            Assert.AreEqual(gpResult, updatedResults);
        }

        [TestMethod]
        public void GetDriverWinsByIdTest()
        {
            var circuit1 = new Circuit(1, "Circuit One", 50, 5.8, 20, 9.5);
            var circuit2 = new Circuit(2, "Circuit Two", 60, 6.2, 22, 8.9);
            var gp1 = new GP(1, circuit1, DateOnly.FromDateTime(DateTime.Now));
            var gp2 = new GP(2, circuit2, DateOnly.FromDateTime(DateTime.Now.AddDays(1)));
            var gp3 = new GP(3, circuit1, DateOnly.FromDateTime(DateTime.Now.AddDays(2)));

            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(DateTime.Now));
            var driver = new Driver(1, 25, "John", "Doe", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);
            var driver2 = new Driver(2, 25, "John2", "Doe2", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);
            var driver3 = new Driver(3, 25, "John3", "Doe3", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);

            var gpResults1 = new List<GPResult>
    {
        new GPResult(gp1, 0, driver, TimeSpan.FromSeconds(100), TimeSpan.FromMinutes(60), 200, 150),
        new GPResult(gp1, 0, driver3, TimeSpan.FromSeconds(102), TimeSpan.FromMinutes(62), 198, 147),
        new GPResult(gp1, 0, driver2, TimeSpan.FromSeconds(101), TimeSpan.FromMinutes(60), 198, 147)
    };
            var gpResults2 = new List<GPResult>
    {
        new GPResult(gp2, 0, driver3, TimeSpan.FromSeconds(95), TimeSpan.FromMinutes(60), 200, 150),
        new GPResult(gp2, 0, driver, TimeSpan.FromSeconds(97), TimeSpan.FromMinutes(62), 198, 147),
        new GPResult(gp2, 0, driver2, TimeSpan.FromSeconds(80), TimeSpan.FromMinutes(60), 198, 147)
    };
            var gpResults3 = new List<GPResult>
    {
        new GPResult(gp3, 0, driver3, TimeSpan.FromSeconds(100), TimeSpan.FromMinutes(60), 200, 150),
        new GPResult(gp3, 0, driver, TimeSpan.FromSeconds(98), TimeSpan.FromMinutes(58), 198, 147),
        new GPResult(gp3, 0, driver2, TimeSpan.FromSeconds(101), TimeSpan.FromMinutes(61), 198, 147)
    };

            gpResultManager.SetGPResult(gpResults1);
            gpResultManager.SetGPResult(gpResults2);
            gpResultManager.SetGPResult(gpResults3);

            int wins = gpResultManager.GetDriverWinsById(driver.ID);

            Assert.AreEqual(2, wins);
        }

        [TestMethod]
        public void GetTeamAveragePositionByIdTest()
        {
            var circuit1 = new Circuit(1, "Circuit One", 50, 5.8, 20, 9.5);
            var gp1 = new GP(1, circuit1, DateOnly.FromDateTime(DateTime.Now));

            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(DateTime.Now));
            var team2 = new Team(2, "Team Alpha2", DateOnly.FromDateTime(DateTime.Now));
            var driver1 = new Driver(1, 25, "John", "Doe", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);
            var driver2 = new Driver(2, 26, "Alice", "Smith", DateOnly.FromDateTime(new DateTime(1991, 2, 2)), team);
            var driver3 = new Driver(3, 27, "Alice2", "Smith", DateOnly.FromDateTime(new DateTime(1991, 2, 2)), team2);
            var driver4 = new Driver(4, 28, "John2", "Smith", DateOnly.FromDateTime(new DateTime(1991, 2, 2)), team2);

            var gpResults = new List<GPResult>
    {
        new GPResult(gp1, 0, driver1, TimeSpan.FromSeconds(100), TimeSpan.FromMinutes(60), 200, 150),
        new GPResult(gp1, 0, driver2, TimeSpan.FromSeconds(102), TimeSpan.FromMinutes(62), 198, 147),
        new GPResult(gp1, 0, driver3, TimeSpan.FromSeconds(101), TimeSpan.FromMinutes(61), 199, 146),
        new GPResult(gp1, 0, driver4, TimeSpan.FromSeconds(103), TimeSpan.FromMinutes(61), 199, 146)
    };

            gpResultManager.SetGPResult(gpResults);

            double averagePosition = gpResultManager.GetTeamAveragePositionById(team.ID);

            double expectedAverage = (1 + 4) / 2.0;
            Assert.AreEqual(expectedAverage, averagePosition, 0.001);
        }


    }
}
