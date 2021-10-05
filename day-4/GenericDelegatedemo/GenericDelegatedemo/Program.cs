using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateDemo
{
    public delegate T OurDel<T>(T var1, T var2);
    public class Emp
    {
        public static string EmpFullName(string fname, string lname)
        {
            return fname+ ' '+ lname;
        }

        public static double InHandSalary(double netSalary, double tax)
        {
            return netSalary - tax;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OurDel<string> del = new OurDel<string>(Emp.EmpFullName);
            Console.WriteLine("Using generic delegate for string: ");
            Console.WriteLine(del("John","Doe"));
            OurDel<double> del2 = new OurDel<double>(Emp.InHandSalary);
            Console.WriteLine("Using generic delegate for double: ");
            Console.WriteLine(del2(12500.5,2500.55));
            Console.ReadKey();
        }
    }
}
