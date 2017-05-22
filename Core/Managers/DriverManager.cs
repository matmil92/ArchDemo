using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Database_Layer;
using Repository.Interfaces;
using Repository.Repositores;

namespace Core.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriver _iDriver;
        private readonly IDriverCar _iDriverCar;
        public DriverManager(IDriver _iDriver, IDriverCar _iDriverCar)
        {
            this._iDriver = _iDriver;
            this._iDriverCar = _iDriverCar;
        }

        public bool AddCarToDriver(int carId, int driverId)
        {
             return  _iDriverCar.AddDriverCar(driverId, carId);
        }

        public bool AddNewDriver(Driver driver)
        {
           return _iDriver.AddNewDriver(driver);
        }

        public Driver GetDriverDetails(int id)
        {
            return _iDriver.GetDriver(id);
        }

        public List<Driver> GetDriverList()
        {
            return _iDriver.GetDrivers();
        }
    }
}