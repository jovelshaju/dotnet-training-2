using IntroToASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToASP.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Welcome";
        }

        public ActionResult Display()
        {
            List<Employee> listEmp = new List<Employee>()
            {
                new Employee() {EId=1, EName="Levi", Salary=50000.00, DoJ=new DateTime(day:12,month:06,year:2020)},
                new Employee() {EId=2, EName="Eren", Salary=60000.00, DoJ=new DateTime(day:01,month:01,year:2021)},
                new Employee() {EId=1, EName="Mikasa", Salary=55000.00, DoJ=new DateTime(day:28,month:02,year:2021)}
            };

            return View(listEmp);
        }
    }
}