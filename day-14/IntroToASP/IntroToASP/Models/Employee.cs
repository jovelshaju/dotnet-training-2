using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToASP.Models
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public double Salary { get; set; }
        public DateTime DoJ { get; set; }
    }
}