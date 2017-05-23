using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Database_Layer;
using Repository.Interfaces;
using Repository.Repositores;
using Core.Builders;
using Core.Directors;
using Core.Factories;

namespace Core.Managers
{
    public class CarManager : ICarManager
    {
        private ICar _iCar;
        private IDriverCar _iDriverCar;

        public CarManager(ICar _iCar, IDriverCar _iDriverCar)
        {
            this._iCar = _iCar;
            this._iDriverCar = _iDriverCar;
        }

        public bool AddDriverToCar(int carId, int driverId)
        {
           return _iDriverCar.AddDriverCar(driverId, carId);
        }

        public bool AddNewCar(Car car)
        {
           return _iCar.AddNewCar(car);
        }

        public bool AddNewCarFromBuilder(int version)
        {
            ICarFactory factory = new CarFactory();
            return AddNewCar(factory.GetCarFromBuilder(version));
        }

        public bool DeleteCar(int id)
        {
            Car car = _iCar.GetCar(id);
            return _iCar.DeleteCar(car);
        }

        public Car GetCarDetails(int id)
        {
            return _iCar.GetCar(id);
        }

        public List<Car> GetCarList()
        {   
            return _iCar.GetCarList();
        }
    }
}