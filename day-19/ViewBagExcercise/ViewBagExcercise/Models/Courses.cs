using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewBagExcercise.Models
{
    public class Courses
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public double CFee { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
    }
}