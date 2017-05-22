using Repository.Database_Layer;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Repositores
{
    public class CarRepository : ICar
    {

        public Boolean AddNewCar(Car car)
        {
            try
            {
                using (var db = new RossDBEntities())
                {
                    db.Cars.Add(car);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public bool DeleteCar(Car car)
        {
            try
            {
                using (var db = new RossDBEntities())
                {
                    db.Cars.Attach(car);
                    db.Cars.Remove(car);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public Car GetCar(int id)
        {
            using (var db = new RossDBEntities())
            {
                return db.Cars.Find(id);
            }
        }

        public List<Car> GetCarList()
        {
            using (var db = new RossDBEntities())
            {
                return db.Cars.ToList();
            }
        }


    }
}