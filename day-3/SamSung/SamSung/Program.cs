using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toshiba;
using Dell;

namespace SamSung
{
    class Program
    {
        static void Main(string[] args)
        {
            Toshiba.Laptop lap1 = new Toshiba.Laptop();
            Dell.Laptop lap2 = new Dell.Laptop();
            Mobile mob1 = new Mobile();
            lap1.Display();
            lap2.Display();
            mob1.Display();
            Console.ReadKey();
        }
    }
}

namespace Toshiba
{
    class Laptop
    {
        
        public void Display()
        {
            Console.WriteLine("Toshiba Laptop!");
        }
    }
}
