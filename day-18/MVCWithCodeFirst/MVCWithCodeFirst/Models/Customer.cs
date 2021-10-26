using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithCodeFirst.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double ODLimit { get; set; }
        public DateTime MStartDate { get; set; }
        public DateTime MEdnDate { get; set; }
    }
}