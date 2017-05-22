using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICar
    {
        List<Car> GetCarList();
        Boolean AddNewCar(Car car);
        Car GetCar(int id);
        Boolean DeleteCar(Car car);
    }
}
