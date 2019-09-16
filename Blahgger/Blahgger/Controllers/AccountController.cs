using System;
using System.Globalization;
using Blahgger.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcAuthWalkthrough.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValidField("Email") && ModelState.IsValidField("Password"))
            {
                // TODO get the user record from the database

                // TODO check if the passwords match
                if (!(user.Email == "james@smashdev.com" && user.Password == "password"))
                {
                    ModelState.AddModelError("", "Login failed.");
                }
            }

            if (ModelState.IsValid)
            {
                // Login the user.
                FormsAuthentication.SetAuthCookie(user.Email, false);

                // Send them to the home page.
                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}