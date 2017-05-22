using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDriverManager
    {
        List<Driver> GetDriverList();
        Driver GetDriverDetails(int id);
        Boolean AddNewDriver(Driver driver);
        Boolean AddCarToDriver(int carId, int driverId);
    }
}
