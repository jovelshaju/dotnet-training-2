using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTypesDemo
{
    class ThreadDemo
    {
        public static void JobOne()
        {
            Console.WriteLine("Displaying 1-10: ");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of task!");
        }
    }
    class Program
    {   
        public static void BgThreadWObject(Object stateInfo)
        {
            Emp emp = (Emp)stateInfo;
            Console.WriteLine("Welcome to Threadpool!\n---------------");
            Console.WriteLine($"ID: {emp.EId}");
            Console.WriteLine($"Name: {emp.EName}");
            Console.WriteLine($"Designation: {emp.EDesig}");

        }
        static void Main(string[] args)
        {
            Emp emp = new Emp(101, "John", "Manager");
            ThreadPool.QueueUserWorkItem(BgThreadWObject, emp);

            Console.ReadLine();
        }

    }
}
