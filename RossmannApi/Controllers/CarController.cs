using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RossmannApi.Controllers
{
    [RoutePrefix("api/cars")]
    public class CarController : ApiController
    {
        private readonly ICarManager iCarManager;
        public CarController(ICarManager iCarManager)
        {
            this.iCarManager = iCarManager;
        }
        [Route("GetCarList")]
        public IHttpActionResult GetCars()
        {
            return Ok(iCarManager.GetCarList());
        }
    }
}
