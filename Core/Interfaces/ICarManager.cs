using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICarManager
    {
        List<Car> GetCarList();
        Car GetCarDetails(int id);
        Boolean AddNewCar(Car car);
        Boolean DeleteCar(int id);
        Boolean AddDriverToCar(int carId, int driverId); 
    }
}
