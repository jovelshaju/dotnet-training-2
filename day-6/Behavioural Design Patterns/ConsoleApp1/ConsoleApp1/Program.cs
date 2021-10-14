using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum per
        {
            a, b, c, d
        }
        static void Main(string[] args)
        {
            per.a = 10;
            Console.WriteLine(per.b);

        }
    }
}
