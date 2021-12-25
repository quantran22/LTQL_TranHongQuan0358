using LTQL_1721050358.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LTQL_1721050358.Controllers
{
    public class AccountsController : Controller
    {// GET: Accounts
        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Login(Accounts acc)
        {
            if (acc.UserName == "Admin" && acc.password == "123456")
            {
                FormsAuthentication.SetAuthCookie(acc.UserName, true);
                return RedirectToAction("About", "Home");
            }
            return View();

        }
        public ActionResult logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}