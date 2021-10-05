using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Nursery.Tables);
            Thread thread2 = new Thread(Nursery.Display);
            Thread thread3 = new Thread(Nursery.Numbers);

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread3.Start();

            Console.ReadKey();
        }
    }
}
