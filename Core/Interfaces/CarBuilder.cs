using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Interfaces
{
    public abstract class CarBuilder
    {
        protected Car car;

        public void CreateCar()
        {
            car = new Car();
        }
        public Car GetObject()
        {
            return car;
        }
        public abstract void SetNewModelName();
        public abstract void SetNewEngineProperties();
    }
}