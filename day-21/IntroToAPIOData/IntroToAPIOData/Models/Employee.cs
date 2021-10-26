using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntroToAPIOData.Models
{
    [Table("Employee")]
    public class Employee
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public double Salary { get; set; }
    }
}