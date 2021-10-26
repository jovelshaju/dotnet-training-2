using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCPartialView.Models
{
    public class Emp
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DoJ { get; set; }

    }
}