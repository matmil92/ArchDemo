﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Builders
{
    public class MercedesBuilder : CarBuilder
    {
        public override void SetNewEngineProperties()
        {
            car.engineCapacity = 5.0;
            car.enginePower = 320;
        }

        public override void SetNewModelName()
        {
            car.companyName = "Mercedes-Benz";
            car.modelName = "W222";
        }
    }
}