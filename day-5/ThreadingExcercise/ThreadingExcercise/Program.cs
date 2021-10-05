using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(KidLearning.DisplayDays);
            Thread thread2 = new Thread(KidLearning.DisplayMonths);
            Thread thread3 = new Thread(KidLearning.DisplayFruits);
            Thread thread4 = new Thread(KidLearning.DisplayWordMeaning);

            Console.WriteLine("----Welcome to Learning-----");
            Console.WriteLine("List of Days\n-------");
            thread1.Start();
            thread1.Join();
            Thread.Sleep(5000);
            Console.WriteLine("List of Months\n-------");
            thread2.Start();
            thread2.Join();
            Console.WriteLine("List of Fruits\n-------");
            thread3.Start();
            Console.WriteLine("List of Words and Meanings\n-------");
            thread4.Start();

            Console.ReadKey();
        }
    }
}
