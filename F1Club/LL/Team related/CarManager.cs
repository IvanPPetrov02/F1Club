using System;
using System.Collections.Generic;
using System.Linq;

namespace LL.Team_related
{
    public class CarManager
    {
        private ICarDAO carDAO;
        private static List<Car> Cars = new List<Car>();

        public CarManager(ICarDAO carDAO)
        {
            this.carDAO = carDAO;
            PopulateIfEmpty();
        }

        private void PopulateIfEmpty()
        {
            if (!Cars.Any())
            {
                RefreshCarsFromDatabase();
            }
        }

        private void RefreshCarsFromDatabase()
        {
            Cars.Clear();
            Cars = carDAO.GetAllCars().ToList();
        }
        private int GetLastInsertedId()
        {
            return carDAO.GetLastInsertedId();
        }

        public void AddCar(Car car)
        {
            carDAO.AddCar(car);
            car.ID = GetLastInsertedId();
            Cars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            PopulateIfEmpty();
            return Cars;
        }

        public Car GetCarById(int carId)
        {
            PopulateIfEmpty();
            return Cars.FirstOrDefault(car => car.ID == carId);
        }

        public void UpdateCar(Car car)
        {
            carDAO.UpdateCar(car);
            RefreshCarsFromDatabase();
            Car existingCar = Cars?.First(c => c.ID == car.ID);
            if (existingCar != null)
            {
                existingCar.Team = car.Team;
                existingCar.Chassis = car.Chassis;
                existingCar.Engine = car.Engine;
                existingCar.HandlingScore = car.HandlingScore;
                existingCar.AccelerationScore = car.AccelerationScore;
                existingCar.BreakingScore = car.BreakingScore;
                existingCar.TopSpeedPossible = car.TopSpeedPossible;
            }
        }

        public void DeleteCar(int id)
        {
            carDAO.DeleteCar(id);
            RefreshCarsFromDatabase();
            Car carToRemove = Cars?.FirstOrDefault(c => c.ID == id);
            if (carToRemove != null)
            {
                Cars.Remove(carToRemove);
            }
        }

        public Dictionary<DateOnly, List<int>> TeamsHaveCarForSeason()
        {
            PopulateIfEmpty();
            Dictionary<DateOnly, List<int>> seasonsWithTeams = new Dictionary<DateOnly, List<int>>();

            foreach (Car car in Cars)
            {
                DateOnly season = car.SeasonUsed;
                int teamId = car.Team.ID;

                if (seasonsWithTeams.ContainsKey(season))
                {
                    if (!seasonsWithTeams[season].Contains(teamId))
                    {
                        seasonsWithTeams[season].Add(teamId);
                    }
                }
                else
                {
                    seasonsWithTeams.Add(season, new List<int> { teamId });
                }
            }

            return seasonsWithTeams;
        }

    }
}
