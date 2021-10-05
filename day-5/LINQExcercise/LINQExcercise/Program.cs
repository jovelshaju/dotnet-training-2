using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> empList = new List<Emp>()
            {
                new Emp() {Name="Rihanna", Profession="Developer", Salary=12500.00, DoJ = new DateTime(day:01, month:05, year:2009) },
                new Emp() {Name="Justin", Profession="Manager", Salary=22500.00, DoJ = new DateTime(day:24, month:09, year:2006) },
                new Emp() {Name="Shawn", Profession="HR", Salary=12600.00, DoJ = new DateTime(day:09, month:07, year:2011) },
                new Emp() {Name="Charlie", Profession="Sales", Salary=30000.00, DoJ = new DateTime(day:22, month:11, year:2019) },
                new Emp() {Name="Arianna", Profession="Tester", Salary=112500.00, DoJ = new DateTime(day:05, month:10, year:2020) },
                new Emp() {Name="Eddie", Profession="Tester", Salary=102500.00, DoJ = new DateTime(day:09, month:12, year:2017) },
                new Emp() {Name="Sam", Profession="Developer", Salary=82500.00, DoJ = new DateTime(day:15, month:07, year:2011) },
                new Emp() {Name="riya", Profession="HR", Salary=42500.00, DoJ = new DateTime(day:28, month:02, year:2015) },

            };

            Console.WriteLine("Showing Details in Descending order of Profession\n------------------------------");

            var empListByProfession = empList.OrderByDescending(emp => emp.Profession).ToList<Emp>();

            foreach (dynamic emp in empListByProfession)
            {
                Console.WriteLine($"Name: {emp.Name} \t Profession: {emp.Profession} \t Salary: {emp.Salary} \t\t DoJ: {emp.DoJ.ToString("dd-MM-yy")}");
            }

            Console.WriteLine("\nShowing List of Developers\n-----------------");

            var empDevelopersList = empList.Where(emp => emp.Profession == "Developer").ToList<Emp>();

            foreach (Emp emp in empDevelopersList)
            {
                Console.WriteLine($"Name: {emp.Name} \t Profession: {emp.Profession} \t Salary: {emp.Salary} \t\t DoJ: {emp.DoJ.ToString("dd-MM-yy")}");
            }

            Console.ReadKey();
        }
    }
}
