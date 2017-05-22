using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Database_Layer;
using System.Data.Entity;

namespace Repository.Repositores
{
    public class DriverRepository : IDriver
    {
        public bool AddNewDriver(Driver driver)
        {
            try
            {
                using (var db = new RossDBEntities())
                {
                    db.Drivers.Add(driver);
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

        public bool EditDriver(Driver driver)
        {
            try
            {
                using (var db = new RossDBEntities())
                {
                    db.Entry(driver).State = EntityState.Modified;
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

        public Driver GetDriver(int id)
        {
            using (var db = new RossDBEntities())
            {
                return db.Drivers.Find(id);
            }
        }

        public List<Driver> GetDrivers()
        {
            using (var db = new RossDBEntities())
            {
                return db.Drivers.ToList();
            }
        }

        public bool DeleteDriver(Driver driver)
        {
            try
            {
                using (var db = new RossDBEntities())
                {
                    db.Drivers.Remove(driver);
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
    }
}