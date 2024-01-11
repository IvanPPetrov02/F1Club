using LL.Team_related;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Driver_related
{
    public class DriverManager
    {
        IDriverDAO driverDAO;

        public DriverManager(IDriverDAO driverDAO)
        {
            this.driverDAO = driverDAO;
        }

        private static List<Driver>? Drivers = new List<Driver>();

        private int GetLastID()
        {
            try
            {
                return driverDAO.GetLastID();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void PopulateIfEmpty()
        {
            if (Drivers.Any())
            {
                return;
            }
            else
            {
                RefreshDriversFromDatabase();
            }
        }

        public void CreateDriver(Driver Driver)
        {
            try
            {
                driverDAO.CreateDriver(Driver);
                Driver.ID = GetLastID();
                Drivers.Add(Driver);

            }
            catch (Exception)
            {
                return;
            }
        }

        public void DeleteDriver(int id)
        {
            try
            {
                driverDAO.DeleteDriver(id);

                PopulateIfEmpty();
                Driver driverToRemove = Drivers?.FirstOrDefault(Driver => Driver.ID == id);
                if (driverToRemove != null)
                {
                    Drivers.Remove(driverToRemove);
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        private void RefreshDriversFromDatabase()
        {
            Drivers?.Clear();

            foreach (Driver driver in driverDAO.GetAllDrivers())
            {
                Drivers?.Add(driver);
            }
        }

        public List<Driver>? GetAllDrivers()
        {
            RefreshDriversFromDatabase();
            return Drivers;
        }

        public int GetAllTimePoints(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCurrentPoints(int id)
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverByID(int id)
        {
            PopulateIfEmpty();
            Driver driver = Drivers?.FirstOrDefault(driver => driver.ID == id);
            return driver;
        }

        public int GetNumberOfWins(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(Driver Driver)
        {
            try
            {
                driverDAO.UpdateDriver(Driver);
                PopulateIfEmpty();
                Driver existingDriver = Drivers?.FirstOrDefault(d => d.ID == Driver.ID);
                if (existingDriver != null)
                {
                    existingDriver.FirstName = Driver.FirstName;
                    existingDriver.LastName = Driver.LastName;
                    existingDriver.Number = Driver.Number;
                    existingDriver.DateOfBirth = Driver.DateOfBirth;
                    existingDriver.Team = Driver.Team;
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        public List<Driver>? GetAllDriversRefreshed()
        {
            PopulateIfEmpty();
            return Drivers.ToList();
        }

        public List<Driver>? GetDriversByTeamID(int id)
        {
            PopulateIfEmpty();
            return Drivers?.Where(driver => driver.Team.ID == id).ToList();
        }
    }
}
