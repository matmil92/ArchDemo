using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Interfaces;
using Repository.Database_Layer;

namespace RossmanMVC.Controllers
{
    public class CarController : Controller
    {
        protected ICarManager iCarManager;
        public CarController(ICarManager iCarManager)
        {
            this.iCarManager = iCarManager;
        }
        public ActionResult Index()
        {
            return View(iCarManager.GetCarList());
        }
        public ActionResult Create()
        {
            return View(new Car());
        }
        [HttpPost]
        public ActionResult Create(Car model)
        {
            if (iCarManager.AddNewCar(model))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Details(int id)
        {
            return View(iCarManager.GetCarDetails(id));
        }
        public ActionResult Delete(int id)
        {
            if(iCarManager.DeleteCar(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
    }
}