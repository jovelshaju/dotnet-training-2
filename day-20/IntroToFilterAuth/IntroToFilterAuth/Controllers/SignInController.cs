using IntroToFilterAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToFilterAuth.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        [HttpGet]
        public ActionResult SignIn()
        {
            return View(new SignIn());
        }

        [HttpPost]
        public ActionResult SignIn(SignIn objs)
        {
            if (!ModelState.IsValid)
            {
                return View(objs);
            }
            else
            {
                if((objs.UserName=="sam")&& (objs.UserPwd == "sam@123")){
                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserName or Password");
                    return View(objs);
                }
            }
        }
    }
}