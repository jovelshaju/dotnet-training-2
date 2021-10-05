using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace IntroToDelegate
{
    public delegate void OurDel(string name);
    public delegate void CalcDel(double num1, double num2);

    public class OurClass
    {
        public static void Welcome(string name)
        {
            Console.WriteLine("Welcome {0}!",name);
        }
        public static string Display(string name)
        {
            return "Hello " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //OurDel ourDel = new OurDel(OurClass.Welcome);
            //ourDel("John");
            // ourDel = new OurDel(OurClass.Display); // Error here, different signature
            //Calculator calc = new Calculator();
            //CalcDel calcDel = new CalcDel(calc.Add);
            //Console.WriteLine("After adding one method...");
            //calcDel(22.24, 18.6);
            //calcDel += new CalcDel(calc.Sub);
            //Console.WriteLine("After adding two method...");

            //calcDel(22.24, 18.6);

            //Func<double, double, double> func = calc.Add2;
            //Console.WriteLine(func(23.56, 56.98));

            //------Func requires return value------

            //Func<int, string, string> fn1 = (int id, string name) => { return "Employee ID: " + id + " \nEmployee Name: " + name + ""; };
            //Console.WriteLine("Employee Details\n=======");
            //Console.WriteLine(fn1(101, "john"));

            //Func<double, double, double> fn2 = (sal, tax) => { return sal - (sal * tax/100); };
            //Console.WriteLine("Net Salary: ");
            //Console.WriteLine(fn2(500000.00,12.5));

            //------Action does not have return value----
            //Action<int, int> add = (n1, n2) => { Console.WriteLine("Sum of {0} and {1} : {2}", n1, n2, n1 + n2); };
            //add(1, 2);

            //Predicate requires boolean return type
            Predicate<int> condition = n =>  n >= 18; ;
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Eligible for voting: "+condition(age));
            Console.ReadKey();
        }
    }
}
