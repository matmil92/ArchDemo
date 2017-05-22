using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Builders
{
    public class AlfaRomeoBuilder : CarBuilder
    {
        public override void SetNewModelName()
        {
            car.companyName = "Alfa Romeo";
            car.modelName = "Gullia";
            car.engineCapacity = 3.2;
            car.enginePower = 240;
        }
    }
}