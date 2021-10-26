using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFilterExercise.Models
{
    public class Employee
    {[Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}