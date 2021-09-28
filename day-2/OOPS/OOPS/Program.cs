using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dev devObj = new Dev(30, "Rahul", "BackEnd", "Lazarus");
            devObj.Display();
            Console.ReadKey();
        }
        
    }
}
