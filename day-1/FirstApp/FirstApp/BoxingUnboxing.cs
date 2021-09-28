using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class BoxingUnboxing
    {
        static void Main2()
        {
            int num1 = 25;
            Object obj;
            obj = num1;

            Console.WriteLine("Boxed: "+ obj.GetType());
            int num2 = (int)obj;
            Console.WriteLine("Unboxed: "+ num2.GetType());

            Console.ReadKey();
        }
    }
}
