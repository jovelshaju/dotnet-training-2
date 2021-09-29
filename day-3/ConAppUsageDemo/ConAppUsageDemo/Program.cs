using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib; //We integrate external lib my adding it in References

namespace ConAppUsageDemo
{
    public static class OurCalc
    {
        public static void Welcome(this Calculator obj)
        {
            Console.WriteLine("Welcome to our Calculator");
            obj.Name="Hello";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string choice = "n";
            int opt;
            do
            {
                Console.WriteLine("Enter number 1:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2:");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose an option: \n =========");
                Console.WriteLine(" 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Average");
                Console.Write("Enter your option: ");
                opt = int.Parse(Console.ReadLine());
                Calculator calc = new Calculator();
                calc.Welcome();
                switch (opt)
                {
                    default: Console.WriteLine("Invalid Option!");
                        break;
                    case 1: Console.WriteLine("Addition of {0} and {1} : {2}",num1,num2,calc.Add(num1,num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction of {0} and {1} : {2}", num1, num2, calc.Diff(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Product of {0} and {1} : {2}", num1, num2, calc.Multi(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Division of {0} and {1} : {2}", num1, num2, calc.Div(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("Average of {0} and {1} : {2}", num1, num2, calc.Avg(num1, num2));
                        break;
                }
                Console.WriteLine("Enter y to continue or Press any other key to exit: ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");
        }
    }
}
