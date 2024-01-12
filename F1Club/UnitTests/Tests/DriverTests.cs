using LL;
using LL.Driver_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Fakers;

namespace UnitTests.Tests
{
    [TestClass]
    public class DriverTests
    {
        DriverManager driverManager = new DriverManager(new FakeDriverDAO());

        [TestMethod]
        public void AddDriverTest()
        {
            var team = new Team(1, "Team Alpha", DateOnly.FromDateTime(new DateTime(2000, 1, 1)));
            var driver = new Driver(0, 77, "John", "Doe", DateOnly.FromDateTime(new DateTime(1985, 1, 1)), team);

            driverManager.CreateDriver(driver);
            var addedDriver = driverManager.GetDriverByID(driver.ID);

            Assert.IsNotNull(addedDriver);
        }

        [TestMethod]
        public void UpdateDriverTest()
        {
            var team = new Team(2, "Team Beta", DateOnly.FromDateTime(new DateTime(2005, 1, 1)));
            var driver = new Driver(0, 88, "Alice", "Smith", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), team);
            driverManager.CreateDriver(driver);

            driver.FirstName = "Alicia";
            driver.LastName = "Johnson";

            driverManager.UpdateDriver(driver);
            var updatedDriver = driverManager.GetDriverByID(driver.ID);

            Assert.IsNotNull(updatedDriver);
            Assert.AreEqual("Alicia", updatedDriver.FirstName);
            Assert.AreEqual("Johnson", updatedDriver.LastName);
        }

        [TestMethod]
        public void DeleteDriverTest()
        {
            var team = new Team(3, "Team Gamma", DateOnly.FromDateTime(new DateTime(2010, 1, 1)));
            var driver = new Driver(0, 99, "Bob", "Brown", DateOnly.FromDateTime(new DateTime(1995, 1, 1)), team);
            driverManager.CreateDriver(driver);

            driverManager.DeleteDriver(driver.ID);
            var deletedDriver = driverManager.GetAllDrivers();

            Assert.AreEqual(0, deletedDriver.Count);
        }

        [TestMethod]
        public void GetAllDriversTest()
        {
            var teamAlpha = new Team(1, "Team Alpha", DateOnly.FromDateTime(new DateTime(2000, 1, 1)));
            var teamBeta = new Team(2, "Team Beta", DateOnly.FromDateTime(new DateTime(2005, 1, 1)));

            var driver1 = new Driver(0, 77, "John", "Doe", DateOnly.FromDateTime(new DateTime(1985, 1, 1)), teamAlpha);
            var driver2 = new Driver(0, 88, "Alice", "Smith", DateOnly.FromDateTime(new DateTime(1990, 1, 1)), teamBeta);
            var driver3 = new Driver(0, 99, "Bob", "Brown", DateOnly.FromDateTime(new DateTime(1995, 1, 1)), teamAlpha);

            driverManager.CreateDriver(driver1);
            driverManager.CreateDriver(driver2);
            driverManager.CreateDriver(driver3);

            var expectedDrivers = new List<Driver> { driver1, driver2, driver3 };

            var drivers = driverManager.GetAllDrivers();

            Assert.AreEqual(expectedDrivers.Count, drivers.Count);

            foreach (var expectedDriver in expectedDrivers)
            {
                var retrievedDriver = drivers.FirstOrDefault(d => d.ID == expectedDriver.ID);
                Assert.IsNotNull(retrievedDriver);
                Assert.AreEqual(expectedDriver.FirstName, retrievedDriver.FirstName);
                Assert.AreEqual(expectedDriver.LastName, retrievedDriver.LastName);
                Assert.AreEqual(expectedDriver.Team.ID, retrievedDriver.Team.ID);
            }
        }

    }
}
