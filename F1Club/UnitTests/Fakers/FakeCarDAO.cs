using LL.Team_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeCarDAO : ICarDAO
    {
        private int lastInsertedId;
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            lastInsertedId++;
            car.ID = lastInsertedId;
            cars.Add(car);
        }

        public int GetLastInsertedId()
        {
            return lastInsertedId;
        }

        public void DeleteCar(int id)
        {
            cars.RemoveAll(c => c.ID == id);
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public void UpdateCar(Car car)
        {
            var existingCar = cars.FirstOrDefault(c => c.ID == car.ID);
            if (existingCar != null)
            {
                cars.Remove(existingCar);
                cars.Add(car);
            }
        }
    }

}
