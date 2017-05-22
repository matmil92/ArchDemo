using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDriverCar
    {
        Boolean AddDriverCar(int driverId, int carId);
        List<Car> GetCarByDriver(int driverId);
        List<Driver> GetDriverByCar(int carId);
    }
}
