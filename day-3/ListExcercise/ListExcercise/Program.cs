using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListExcercise
{
    class Program
    {
        static void CompExcercise()
        {
            Components obj = new Components();
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("Choose an option: \n=========");
                Console.WriteLine("1.Display List \n2.Change item \n3.Exit");
                Console.Write("Enter the option: ");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    default:
                        Console.WriteLine("\nInvalid option!");
                        break;
                    case 1:
                        obj.Display();
                        break;
                    case 2:
                        obj.ChangeData();
                        break;
                    case 3:
                        flag = 0;
                        break;
                }
            Console.WriteLine("");
            }
        }

        static void Demo()
        {
            List<Employee> emplList = new List<Employee>()
            {
                new Employee{Id = 1, Name = "John", DoB = new DateTime(day:1, month:2, year:2010)},
                new Employee{Id = 2, Name = "Peter", DoB = new DateTime(day:5, month:5, year:2007)},
                new Employee{Id = 3, Name = "Sam", DoB = new DateTime(day:23, month:12, year:2014)},
                new Employee{Id = 4, Name = "Denna", DoB = new DateTime(day:17, month:9, year:2009)},
                new Employee{Id = 1, Name = "Leya", DoB = new DateTime(day:31, month:8, year:2012),}
            };
        }
        static void Main(string[] args)
        {
            //CompExcercise();
            Console.ReadKey();
            
        }
    }
}
