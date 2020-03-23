using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // Post request for /Person/Index
        [HttpPost]
        public ActionResult Index(int age)
        {
            if (age < 20)
                ViewBag.Result = "Young";
            else
                if (age < 50)
                ViewBag.Result = "Middle-aged";
            else
                ViewBag.Result = "Old";

            return View();
        }

        // GET: Person/BMI
        public ActionResult BMI()
        {
            var model = new PersonDetails();
            return View(model);
        }

        [HttpPost]  // POST : Person/BMI
        public ActionResult BMI(PersonDetails model)
        {
            if (ModelState.IsValid)  // is data valid??
            {
                var meters = model.Height / 100; // Convert CM to Meters 
                model.BMI = model.Weight / (meters * meters);
                if (model.BMI < 18.5)
                    model.Message = "Under Weight";
                else
                    if (model.BMI < 25)
                    model.Message = "Normal Weight";
                else
                    if (model.BMI < 30)
                    model.Message = "Over Weight";
                else
                    model.Message = "Obesity";
            }
            return View(model);
        }
    }
}