using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main2(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Enter a string: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("String Entered: " + userName);

            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);

            //string fName, lName;
            //int age;
            //char grade;
            //double fee;
            //Console.WriteLine("Enter Student details: \n=================");
            //Console.WriteLine("Enter first name:");
            //fName = Console.ReadLine();
            //Console.WriteLine("Enter last name:");
            //lName = Console.ReadLine();
            //Console.WriteLine("Enter age:");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter grade:");
            //grade = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter fees:");
            //fee = double.Parse(Console.ReadLine());

            //Console.WriteLine("\n Welcome Mr.\\Ms. {0}, your details are as follows: \n Name: {0} \n Age: {1} \n Grade: {2} \n Fees: {3}", fName+" "+lName, age, grade, fee);

            Console.WriteLine("Mark checker \n============");
            int preMarks;
            Console.WriteLine("Enter the pre-exam marks:");
            preMarks  = int.Parse(Console.ReadLine());
            if (preMarks > 45)
            {
                int finalMarks;
                Console.WriteLine("Enter the final-exam marks:");
                finalMarks = int.Parse(Console.ReadLine());
                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            }
            else
            {
                Console.WriteLine("Did not clear pre exam");
            }
            Console.ReadKey();
        }
    }
}
