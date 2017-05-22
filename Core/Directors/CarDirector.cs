using Core.Builders;
using Core.Interfaces;
using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Directors
{
    public class CarDirector
    {
        private CarBuilder carBuilder;

        public CarDirector(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }
        public void CreateCar()
        {
            carBuilder.CreateCar();
            carBuilder.SetNewModelName();
        }
        public Car GetCar()
        {
            return carBuilder.GetObject();
        }
    }
}