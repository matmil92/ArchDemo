using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Database_Layer;
using System.Data.Entity;

namespace Repository.Repositores
{
    public class DriverCarRepository : IDriverCar
    {
        public bool AddDriverCar(int driverId, int carId)
        {
            try
            {
                DriverCar driverCar = new DriverCar
                {
                    purchaseDate = DateTime.Now,
                    carId = carId,
                    driverId = driverId
                };
                using (var db = new RossDBEntities())
                {
                    db.DriverCars.Add(driverCar);
                    db.SaveChanges();
                }
                    return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public List<Car> GetCarByDriver(int driverId)
        {
            using (var db = new RossDBEntities())
            {
                return db.DriverCars.Where(c => c.driverId == driverId).Include(c => c.Car).Select(c => c.Car).ToList();
            }
        }

        public List<Driver> GetDriverByCar(int carId)
        {
            using (var db = new RossDBEntities())
            {
               return db.DriverCars.Where(d => d.carId == carId).Include(d=> d.Driver).Select(d=>d.Driver).ToList();
            }
        }
    }
}