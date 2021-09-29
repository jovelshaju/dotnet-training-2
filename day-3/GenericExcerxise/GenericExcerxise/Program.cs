using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExcerxise
{
    class Program
    {
        static void Main(string[] args)
        {
            GenExcercise obj = new GenExcercise();
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("Choose an option: \n=========");
                Console.WriteLine("1.Display List \n2.Delete item \n3.Exit");
                Console.Write("Enter the option: ");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    default:
                        Console.WriteLine("\nInvalid option!");
                        break;
                    case 1:
                        obj.Display();
                        break;
                    case 2:
                        obj.DeleteData();
                        break;
                    case 3:
                        flag = 0;
                        break;
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

