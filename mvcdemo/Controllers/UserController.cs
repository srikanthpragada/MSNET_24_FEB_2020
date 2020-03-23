using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvcdemo.Controllers
{
    public class UserController : Controller
    {
         
        [Authorize]
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.Password == "dummy")
            {
                // valid user so redirect to home
                Session.Add("user", user.Name);
                FormsAuthentication.SetAuthCookie(user.Name, false);
                return RedirectToAction("Home");
            }

            ViewBag.Message = "Login Failed";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}