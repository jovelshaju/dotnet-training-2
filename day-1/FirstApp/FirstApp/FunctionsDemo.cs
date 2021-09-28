using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class FunctionsDemo
    {
        public static int SalaryCalculator(int wHours, int wDays, int projHandles=1, int extras=0 )
        {
            int salary = wHours * wDays * 100 + projHandles * 3000 + extras;
            return salary;
        }

        public static void Main()
        {
            int wHours, wDays, projHandles, extras;
            Console.WriteLine("Choose your posting: \n================");
            Console.WriteLine("1.HR");
            Console.WriteLine("2.Admin");
            Console.WriteLine("3.Software Developer");
            Console.Write("Enter option:");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: 
                    Console.WriteLine("Enter number of working hours:");
                    wHours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    wDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Salary for the month : " + SalaryCalculator(wHours, wDays));
                    break;
                case 2:
                    Console.WriteLine("Enter number of working hours:");
                    wHours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    wDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Project Handles:");
                    projHandles = int.Parse(Console.ReadLine());
                    Console.WriteLine("Salary for the month : " + SalaryCalculator(wHours, wDays, projHandles));
                    break;
                case 3:
                    Console.WriteLine("Enter number of working hours:");
                    wHours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    wDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Project Handles:");
                    projHandles = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter extras:");
                    extras = int.Parse(Console.ReadLine());
                    Console.WriteLine("Salary for the month : " + SalaryCalculator(wHours, wDays, projHandles,extras));
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
