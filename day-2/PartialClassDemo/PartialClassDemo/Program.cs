using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime MStartDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
