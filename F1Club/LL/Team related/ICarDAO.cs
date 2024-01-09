using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Team_related
{
    public interface ICarDAO
    {
        List<Car> GetAllCars();
        void AddCar(Car car);
        void DeleteCar(int id);
        void UpdateCar(Car car);
        int GetLastInsertedId();
    }
}
