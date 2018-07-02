using College.Management.DataProviders;
using College.Management.Entites;
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

        public ActionResult Login()
        {

            ViewBag.Title = "Login";

            return View(new UserDto());
        }

        [HttpPost]
        public ActionResult UserLogin(UserDto user)
        {
            var authenticatedUser  = CollegeRepository.Instance.Login(user);

            Session["AuthUser"] = authenticatedUser;

            return View("Index");
        }

        public ActionResult Registration()
        {
           Session["Roles"] = CollegeRepository.Instance.GetUserRoles();
            return View();
        }

        [HttpPost]
        public ActionResult UserRegistration(UserDto user)
        {
            if (ModelState.IsValid)
            {
               Session["Success"] = CollegeRepository.Instance.RegisterUser(user) == 1 ? true : false;

            }

            return RedirectToAction("Registration");
        }
    }
}
