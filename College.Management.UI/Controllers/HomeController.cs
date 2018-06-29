using College.Management.DataProviders;
using College.Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace College.Management.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            CollegeDbContext context = new CollegeDbContext();

            ViewBag.Title = "Home Page";

            return View(new User());
        }

        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            return View();
        }
    }
}
