using Core.Interfaces;
using Core.Managers;
using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace RossmanApp.Controllers
{
    [RoutePrefix("api/cars")]
    public class CarController : ApiController
    {
        private readonly ICarManager _iCarManager;
        public CarController()
        {

        }
        public CarController(ICarManager _iCarManager)
        {
            this._iCarManager = _iCarManager;
        }
        [Route("GetCars")]
        public IHttpActionResult GetCarList()
        {
            return Ok(_iCarManager.GetCarList());
        }
    }
}
