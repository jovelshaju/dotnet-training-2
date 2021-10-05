using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string direct = "C:\\Users\\jshaju\\Documents\\Training Projects\\soti\\soti-back-end-aug2021\\dotnet-training-2\\day-4\\";
            string subDirect = "Emp";
            string directPath = direct + subDirect;
            try
            {
                if (Directory.Exists(directPath))
                {
                    Console.WriteLine("Folder Already Exists!");
                }
                else
                {
                    Directory.CreateDirectory(directPath);
                    Console.WriteLine("Emp folder created\n");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }

            Console.WriteLine("To create file\n-----------");

            string name;
            DateTime dob;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Date of Birth: ");
            dob = DateTime.Parse(Console.ReadLine());

            string fileName = name + "_" + dob.ToString("dd-MM-yyyy") + ".docx";
            string filePath = directPath + "\\" + fileName;

            try
            {
                Console.WriteLine("Creating File\n--------");
                
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File already exists!");
                }
                else
                {
                    var file = File.Create(filePath);
                    Console.WriteLine("File created successfully!\n");
                    file.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
            

            int id;
            int salary;
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            salary = int.Parse(Console.ReadLine());

            string content = "Employee Details\n=======\nID: "+id+ "\nname: " + name + "\nDOB: " + dob.ToString("dd-MM-yyyy") + "\nSalary: " + salary + "";
            File.AppendAllText(filePath, content);

            Console.WriteLine("\nContent of file:\n========");
            content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
