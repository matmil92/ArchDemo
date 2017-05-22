using Core.Interfaces;
using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RossmanMVC.Controllers
{
    public class DriverController : Controller
    {
        protected IDriverManager iDriverManager;
        public DriverController(IDriverManager iDriverManager)
        {
            this.iDriverManager = iDriverManager;
        }
        public ActionResult Index()
        {
            return View(iDriverManager.GetDriverList());
        }
        public ActionResult Create()
        {
            return View(new Driver());
        }

        [HttpPost]
        public ActionResult Create(Driver model)
        {
            if(iDriverManager.AddNewDriver(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public ActionResult Details(int id)
        {
            return View(iDriverManager.GetDriverDetails(id));
        }
    }
}