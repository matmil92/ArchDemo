using Repository.Database_Layer;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/cars")]
    public class CarController : ApiController
    {
        private ICar _iCar;

        public CarController(ICar _iCar)
        {
            this._iCar = _iCar;
        }
        [Route("GetCarList")]
        public IHttpActionResult GetCars()
        {
            List<Car> cars = _iCar.GetCarList();
            if (cars.Count > 0)
            {
                return Ok(cars);
            }
            return BadRequest();
        }

    }
}
