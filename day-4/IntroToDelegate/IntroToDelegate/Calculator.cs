using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Calculator
    {
        public void Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("The addition of {0} and {1} : {2}",n1,n2,result);
        }
        public double Add2(double n1, double n2)
        {
            double result = n1 + n2;
            return result;
        }
        public void Sub(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("The subtraction of {0} and {1} : {2}", n1, n2, result);
        }
        public void Div(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("The division of {0} and {1} : {2}", n1, n2, result);
        }
        public void Multi(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("The product of {0} and {1} : {2}", n1, n2, result);
        }
        public void Avg(double n1, double n2)
        {
            double result = (n1 + n2)/2;
            Console.WriteLine("The average of {0} and {1} : {2}", n1, n2, result);
        }
    }
}
