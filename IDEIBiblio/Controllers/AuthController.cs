using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDEIBiblio.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        public ActionResult Index()
        {
            ViewData["Username"] = "Username";
            ViewData["Password"] = "Password";
            return View();
        }

        public ActionResult Registo()
        {
            return View();
        }

    }
}
