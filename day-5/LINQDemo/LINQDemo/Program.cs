using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stdntNames = new string[]
            //{
            //    "Arun","Parvathy","Elizabeth","Rahul","Rani"
            //};

            //var names = from anames in stdntNames where anames.Contains('i') select anames;

            //foreach (dynamic item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var nums = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);

            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            List<Emp> empList = new List<Emp>()
            {
                new Emp() {Id=201, Name="Rihanna", Designation="Pop", Salary=12500.00, DoJ = new DateTime(day:01, month:05, year:2009) },
                new Emp() {Id=878, Name="Justin", Designation="Folk", Salary=22500.00, DoJ = new DateTime(day:24, month:09, year:2006) },
                new Emp() {Id=135, Name="Shawn", Designation="Unplugged", Salary=12600.00, DoJ = new DateTime(day:09, month:07, year:2011) },
                new Emp() {Id=453, Name="Charlie", Designation="Vocal", Salary=30000.00, DoJ = new DateTime(day:22, month:11, year:2019) },
                new Emp() {Id=971, Name="Arianna", Designation="Oprah", Salary=112500.00, DoJ = new DateTime(day:05, month:10, year:2020) },
            };

            //var empListById = from emp in empList orderby emp.Id descending select emp;

            var empListById = empList.OrderByDescending(emp => emp.Id).ToList<Emp>();

            foreach (dynamic emp in empListById)
            {
                Console.WriteLine($"ID: {emp.Id} \t Name: {emp.Name} \t Designation: {emp.Designation} \t Salary: {emp.Salary} \t DoJ: {emp.DoJ.ToString("dd-MM-yy")}");
            }

            Console.ReadKey();
        }
    }
}
