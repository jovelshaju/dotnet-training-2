using IntroToFilterAuth.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToFilterAuth.Controllers
{
    [AuthenticationFilter]
    public class SignOutController : Controller
    {
        // GET: SignOut
        public ActionResult SignOut()
        {
            Session["UserId"] = null;
            return View();
        }
    }
}