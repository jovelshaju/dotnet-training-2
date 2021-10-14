using ExcerciseCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcerciseCustomer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> listCust = new List<Customer>()
            {
                new Customer() {CId=1, CName="Levi", OverDraftLimit=50000.00, CEmail="ll@gmail.com"},
                new Customer() {CId=2, CName="Eren", OverDraftLimit=60000.00, CEmail="ee@gmail.com"},
                new Customer() {CId=3, CName="Mikasa", OverDraftLimit=55000.00, CEmail="mm@gmail.com"},
                new Customer() {CId=4, CName="Armin", OverDraftLimit=35000.00, CEmail="aa@gmail.com"},
                new Customer() {CId=5, CName="Sasha", OverDraftLimit=45000.00, CEmail="ss@gmail.com"}

            };
            return View(listCust);
        }
    }
}