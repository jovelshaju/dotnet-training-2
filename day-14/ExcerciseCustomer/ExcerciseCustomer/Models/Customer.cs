using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcerciseCustomer.Models
{
    public class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CEmail { get; set; }
        public double OverDraftLimit { get; set; }
    }
}