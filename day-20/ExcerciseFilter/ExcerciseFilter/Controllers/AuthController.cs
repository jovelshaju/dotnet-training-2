using ExcerciseFilter.Data;
using ExcerciseFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcerciseFilter.Controllers
{
    public class AuthController : Controller
    {
        private ExcerciseFilterContext db = new ExcerciseFilterContext();
        // GET: Auth
        [HttpGet]
        public ActionResult SignIn()
        {
            return View(new EmpAuth());
        }

        [HttpPost]
        public ActionResult SignIn(EmpAuth objs)
        {
            if (!ModelState.IsValid)
            {
                return View(objs);
            }
            else
            {
                var u1 = db.EmpAuths.FirstOrDefault(o => o.UserName == objs.UserName);
                u1.Equals(null);
                if (db.EmpAuths.FirstOrDefault(o=>o.UserName==objs.UserName).Equals(null) && db.EmpAuths.FirstOrDefault(o=>o.UserPwd==objs.UserPwd).Equals(null))
                {
                    
                    ModelState.AddModelError("", "Invalid UserName or Password");
                    return View(objs);
                }
                else
                {
                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
            }
        }
    }
}