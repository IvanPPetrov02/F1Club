using LL;
using LL.Team_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Fakers;

namespace UnitTests.Tests
{
    [TestClass]
    public class CarTests
    {
        CarManager carManager = new CarManager(new FakeCarDAO());

        [TestMethod]
        public void AddCarTest()
        {
            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(new DateTime(2000, 1, 1)));
            var car = new Car(0, team, DateOnly.FromDateTime(DateTime.Now), "Chassis1", "Engine1", 9.5, 8.5, 7.5, 200);

            carManager.AddCar(car);
            var addedCar = carManager.GetCarById(car.ID);

            Assert.IsNotNull(addedCar);
        }

        [TestMethod]
        public void UpdateCarTest()
        {
            var team = new Team(2, "Team Beta", DateOnly.FromDateTime(new DateTime(2005, 1, 1)));
            var car = new Car(0, team, DateOnly.FromDateTime(DateTime.Now), "Chassis2", "Engine2", 8.5, 7.5, 6.5, 190);
            carManager.AddCar(car);

            car.Chassis = "UpdatedChassis";
            car.Engine = "UpdatedEngine";

            carManager.UpdateCar(car);
            var updatedCar = carManager.GetCarById(car.ID);

            Assert.IsNotNull(updatedCar);
            Assert.AreEqual("UpdatedChassis", updatedCar.Chassis);
            Assert.AreEqual("UpdatedEngine", updatedCar.Engine);
        }

        [TestMethod]
        public void DeleteCarTest()
        {
            var team = new Team(3, "Team Gamma", DateOnly.FromDateTime(new DateTime(2010, 1, 1)));
            var car = new Car(0, team, DateOnly.FromDateTime(DateTime.Now), "Chassis3", "Engine3", 9.0, 8.0, 7.0, 195);
            carManager.AddCar(car);

            carManager.DeleteCar(car.ID);
            var deletedCar = carManager.GetCarById(car.ID);

            Assert.IsNull(deletedCar);
        }

        [TestMethod]
        public void TeamsHaveCarForSeasonTest()
        {
            var teamAlpha = new Team(1, "Team Alpha", DateOnly.FromDateTime(new DateTime(2000, 1, 1)));
            var teamBeta = new Team(2, "Team Beta", DateOnly.FromDateTime(new DateTime(2005, 1, 1)));

            var car1 = new Car(0, teamAlpha, DateOnly.FromDateTime(new DateTime(2022, 1, 1)), "ChassisAlpha1", "EngineAlpha1", 9.5, 8.5, 7.5, 200);
            var car2 = new Car(0, teamBeta, DateOnly.FromDateTime(new DateTime(2022, 1, 1)), "ChassisBeta1", "EngineBeta1", 8.5, 7.5, 6.5, 190);
            var car3 = new Car(0, teamAlpha, DateOnly.FromDateTime(new DateTime(2023, 1, 1)), "ChassisAlpha2", "EngineAlpha2", 9.7, 8.6, 7.8, 205);

            carManager.AddCar(car1);
            carManager.AddCar(car2);
            carManager.AddCar(car3);

            var expectedSeasons = new Dictionary<DateOnly, List<int>>
    {
        { DateOnly.FromDateTime(new DateTime(2022, 1, 1)), new List<int> { teamAlpha.ID, teamBeta.ID } },
        { DateOnly.FromDateTime(new DateTime(2023, 1, 1)), new List<int> { teamAlpha.ID } }
    };

            var seasonsWithTeams = carManager.TeamsHaveCarForSeason();

            foreach (var season in expectedSeasons)
            {
                Assert.IsTrue(seasonsWithTeams.ContainsKey(season.Key));
                CollectionAssert.AreEquivalent(season.Value, seasonsWithTeams[season.Key]);
            }
        }
    }
}
