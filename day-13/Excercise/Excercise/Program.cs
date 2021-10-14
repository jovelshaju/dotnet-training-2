using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        static OurExcercise8DBEntities db;
        static void Display()
        {
            db = new OurExcercise8DBEntities();
            try
            {
                List<Emp> listEmp = db.Emps.ToList();
                foreach (Emp emp in listEmp)
                {
                    Console.WriteLine($"Employee Id: {emp.EId}");
                    Console.WriteLine($"Employee Name: {emp.EName}");
                    Console.WriteLine($"Employee Designation: {emp.EDesig}");
                    Console.WriteLine($"Employee Salary: {emp.ESalary}");
                    Console.WriteLine("");
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Display(int id)
        {
            db = new OurExcercise8DBEntities();
            try
            {
                Emp emp = db.Emps.SingleOrDefault(e => e.EId==id);
                if (emp != null)
                {
                    Console.WriteLine("Employee Found");
                    Console.WriteLine($"Employee Name: {emp.EName}");
                    Console.WriteLine($"Employee Designation: {emp.EDesig}");
                    Console.WriteLine($"Employee Salary: {emp.ESalary}");

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Employee Not Found");
                }

            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Display(string name)
        {
            db = new OurExcercise8DBEntities();
            try
            {
                Emp emp = db.Emps.FirstOrDefault(e => e.EName == name);
                if (emp != null)
                {
                    Console.WriteLine("Employee Found");
                    Console.WriteLine($"Employee id: {emp.EId}");
                    Console.WriteLine($"Employee name: {emp.EName}");
                    Console.WriteLine($"Employee Designation: {emp.EDesig}");
                    Console.WriteLine($"Employee Salary: {emp.ESalary}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Employee Not Found");
                }
                

            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main2(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("=================");
                Console.WriteLine(" 1.Show All \n 2.Search By ID \n 3.Search By Name \n 4.Exit");
                Console.Write("Enter the option: ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (k)
                {
                    case 1:
                        Display();
                        break;
                    case 2:
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Display(id);
                        break;
                    case 3:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Display(name);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;


                }
            }
        

        }
    }
}
