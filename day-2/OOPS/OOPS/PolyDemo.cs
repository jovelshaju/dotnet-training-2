using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class PolyDemo
    {
        public void Display()
        {
            Console.WriteLine("Hello There!");
        }
        public void Display(int id)
        {
            Console.WriteLine("Id: "+id);
        }
        public void Display(string name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
}
