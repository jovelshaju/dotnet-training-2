using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{   
    class Employee
    {
        private int eid;
        private string ename;
        private double esalary;
        private static int count = 0;

        public static int Count { get { return count; } } 
        public double Salary
        {
            get { return esalary; }
            set { esalary = value; }
        }

        public string Name
        {
            get { return ename; }
            set {
                if (value.Length < 7)
                {
                    ename = "Invalid Name";
                }
                else
                {
                    ename = value;
                }
                }
        }

        public int Id
        {
            get { return eid; }
            set { eid = value; }
        }

        public Employee()
        {
            count++;
        }

        public void Display()
        {
            Console.WriteLine("Employee ID: "+Id);
            Console.WriteLine("Employee Name: "+Name);
            Console.WriteLine("Employee Salary: "+Salary);
        }

    }
    class Excercise
    {
        public static void Main()
        {
            Employee e1 = new Employee() { Id = 101, Name = "John", Salary = 25000.50 };
            e1.Display();
            Console.WriteLine("\nNo. of Employees: {0}", Employee.Count);
            Employee e2 = new Employee() { Id = 102, Name = "Peter Quill", Salary = 55000.50 };
            e2.Display();
            Employee e3 = new Employee() { Id = 103, Name = "Ben Paul", Salary = 35000.50 };
            e3.Display();
            Console.WriteLine("\nNo. of Employees: {0}", Employee.Count);
            Console.ReadKey();
        }
    }
}
