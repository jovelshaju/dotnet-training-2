using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExcerxise
{
    class Customer
    {
        public string CName { get; set; }
        public string CCity { get; set; }
        public double CODLimit { get; set; }

        public string Display()
        {
            return ("Name: "+CName+" \tCity: "+CCity+" \tCODLimit: "+CODLimit+"");
        }
    }

    
}
