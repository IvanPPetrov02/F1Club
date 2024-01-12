using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeDriverDAO : IDriverDAO
    {
        private int lastInsertedId = 0;
        private List<Driver> drivers = new List<Driver>();

        public void CreateDriver(Driver driver)
        {
            lastInsertedId++;
            driver.ID = lastInsertedId;
            drivers.Add(driver);
        }

        public void DeleteDriver(int id)
        {
            drivers.RemoveAll(d => d.ID == id);
        }

        public List<Driver> GetAllDrivers()
        {
            return new List<Driver>(drivers);
        }

        public int GetLastID()
        {
            return lastInsertedId;
        }

        public void UpdateDriver(Driver driver)
        {
            var existingDriver = drivers.FirstOrDefault(d => d.ID == driver.ID);
            if (existingDriver != null)
            {
                existingDriver.Number = driver.Number;
                existingDriver.FirstName = driver.FirstName;
                existingDriver.LastName = driver.LastName;
                existingDriver.DateOfBirth = driver.DateOfBirth;
                existingDriver.Team = driver.Team;
            }
        }
    }

}
