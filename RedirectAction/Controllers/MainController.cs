using RedirectAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedirectAction.Controllers
{
    public class MainController : Controller
    {
        // GET: Main

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WithFormCollection()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WithFormCollection(FormCollection collection)
        {
            try
            {
                Student obj = new Student();
                obj.Name = collection["Name"];
                return RedirectToAction("WithFormCollection");
            }
            catch
            {
                return View();
            }

        }

    }
}