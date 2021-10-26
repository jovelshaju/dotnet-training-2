using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcerciseFilter.Models
{
    [Table("Employee")]
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public double Salary { get; set; }

    }
}