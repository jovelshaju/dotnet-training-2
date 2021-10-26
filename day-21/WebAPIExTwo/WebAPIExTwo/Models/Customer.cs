using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIExTwo.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double ODLimit { get; set; }
        
    }
}