using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Now()
        {
            return DateTime.Now.ToString();
        }

        public ActionResult Langs()
        {
            var names = new List<String>() { "Java", "Python", "C#", "TypeScript" };
            return PartialView(names);
        }

        public String Discount(double price, int qty)
        {
            // 10 % discount
            // 12 % tax
            var amount = price * qty;
            amount = amount * 0.90;  // after discount
            amount = amount * 1.12;  // after tax
            return amount.ToString();
        }
    }
}