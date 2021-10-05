using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Program
    {
        class Employee
        {
            string[] names = new string[10];

            public string this[int index]
            {
                get { return names[index]; }
                set { names[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[0] = "John";
            emp[1] = "Liya";
            emp[2] = "Peter";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(emp[i]);
            }
            Console.ReadKey();
        }
    }
}
