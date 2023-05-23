using CooperVisionPF.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CooperVisionPF.Controllers
{

    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {

                return View();
            }

        [HttpPost]
        public ActionResult HomePage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Guide()
        {

            return View();
        }

        [HttpPost]
        public ActionResult RequestPage()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            try
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}



