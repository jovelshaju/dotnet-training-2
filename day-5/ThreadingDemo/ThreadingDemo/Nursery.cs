using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace ThreadingDemo
//{
//    class Nursery
//    {
//        public static void Tables()
//        {
//            //Console.Write("Enter a number: ");
//            //int num = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"5 x {i} = {5*i}");
//            }
//        }

//        public enum DayOfWeek {Sun,Mon,Tue,Wed,thu,Fri,Sat };

//        public static void Display()
//        {
//            Console.WriteLine($"Monday is {DayOfWeek.Mon} of the week");
//        }

//        public static void Numbers()
//        {
//            for (int i = 1; i <= 100; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

namespace ThreadingDemo
{
    class Nursery
    {
        public static void Tables()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        public enum DayOfWeek { Sun, Mon, Tue, Wed, thu, Fri, Sat };

        public static void Display()
        {
            Console.WriteLine($"Monday is {DayOfWeek.Mon} of the week");
        }

        public static void Numbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
}