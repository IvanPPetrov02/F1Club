using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IDriverDAO
    {
        void CreateDriver(Driver driver);
        void UpdateDriver(Driver driver);
        void DeleteDriver(int id);
        public List<Driver> GetAllDrivers();
        int GetLastID();
    }
}
