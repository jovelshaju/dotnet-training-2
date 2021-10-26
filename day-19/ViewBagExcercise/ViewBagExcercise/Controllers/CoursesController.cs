using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagExcercise.Models;

namespace ViewBagExcercise.Controllers
{
    public class CoursesController : Controller
    {
        static List<Courses> listCourses;
        // GET: Courses

        public CoursesController()
        {
            listCourses = new List<Courses>()
            {
                new Courses(){CId=1,CName="Cyber Security", CFee=10000, Status="Active", Technology="IT"},
                new Courses(){CId=2,CName="Aerodynamics", CFee=11000, Status="Inactive", Technology="Mechanical"}
            };
        }
        public ActionResult Index()
        {
            var technologies = listCourses.Select(c => c.Technology).Distinct().ToList();
            ViewBag.Message = ' ';
            foreach (var tech in technologies)
            {
                ViewBag.Message += tech.ToString() + " | ";
            }
            ViewData["Msg"] = "Welcome to our courses ";

            return View(listCourses);
        }
    }
}