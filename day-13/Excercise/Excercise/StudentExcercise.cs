using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class StudentExcercise
    {
        static OurExcercise8DBEntities db;

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("=================");
                Console.WriteLine(" 1.Insert Data \n 2.Update Data \n 3.Delete Data \n 4.Search By Id \n 5.Exit");
                Console.Write("Enter the option: ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (k)
                {
                    case 1:
                        InsertData();
                        break;
                    case 2:
                        UpdateData();
                        break;
                    case 3:
                        DeleteData();
                        break;
                    case 4:
                        SearchByID();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;


                }
            }


        }

        private static void SearchByID()
        {
            db = new OurExcercise8DBEntities();

            Console.Write("Enter Id To Search: ");
            int id = int.Parse(Console.ReadLine());

            Student student = db.Students.SingleOrDefault(s => s.SId == id);
            if (student != null)
            {
                Console.WriteLine($"Name: {student.SName}");
                Console.WriteLine($"Fee: {student.SFee}");
                Console.WriteLine($"DOB: {student.SDoB.ToString()}");
                
                db.SaveChanges();
                Console.WriteLine("Record updated");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }

        private static void DeleteData()
        {
            db = new OurExcercise8DBEntities();

            Console.Write("Enter Id To Delete: ");
            int id = int.Parse(Console.ReadLine());
            Student student = db.Students.SingleOrDefault(s => s.SId == id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();

                Console.WriteLine("Record deleted");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }

        private static void UpdateData()
        {
            db = new OurExcercise8DBEntities();            

            Console.Write("Enter Id To Update: ");
            int id = int.Parse(Console.ReadLine());
            Student student = db.Students.SingleOrDefault(s => s.SId == id);
            if (student != null)
            {
                Console.Write("Enter Name: ");
                student.SName = Console.ReadLine();
                Console.Write("Enter Fee: ");
                student.SFee = double.Parse(Console.ReadLine());
                Console.Write("Enter DOB: ");
                student.SDoB = DateTime.Parse(Console.ReadLine());

                db.SaveChanges();

                Console.WriteLine("Record updated");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }            
        }

        private static void InsertData()
        {
            db = new OurExcercise8DBEntities();

            Student student = new Student();

            Console.Write("Enter Id: ");
            student.SId = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            student.SName = Console.ReadLine();
            Console.Write("Enter Fee: ");
            student.SFee = double.Parse(Console.ReadLine());
            Console.Write("Enter DOB: ");
            student.SDoB = DateTime.Parse(Console.ReadLine());

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine("Record Inserted");

        }
    }
}
