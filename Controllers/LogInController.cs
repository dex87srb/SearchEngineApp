using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using SearchEngine.Models;


namespace SearchEngine.Controllers
{
    public class LogInController : Controller
    {
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(User userModel)
        {
            using (AccountEntities db = new AccountEntities())
            {
                var userDetails = db.Credentials.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password.";
                    return View("Index", userModel);
                }
                else
                {
                    Session["UserID"] = userDetails.Id;
                    Session["userName"] = userDetails.UserName;

                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {

            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}

