using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "n";
            int opt;
            do
            {
                Console.WriteLine("Choose an option: \n =========");
                Console.WriteLine(" 1.Rectangle \n 2.Square \n 3.Circle \n 4.Triangle");
                Console.Write("Enter your option: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                    case 1:
                        AreaOfRectangle();
                        break;
                    case 2:
                        AreaOfSquare();
                        break;
                    case 3:
                        AreaOfCircle();
                        break;
                    case 4:
                        AreaOfTriangle();
                        break;
                }
                Console.WriteLine("Enter y to continue or Press any other key to exit: ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");
        }

        static double AreaOfRectangle()
        {
            Rectangle r1 = new Rectangle();
            double result;
            Console.Write("Enter Length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Enter Length: ");
            double br = double.Parse(Console.ReadLine());
            result = r1.Area(len, br);
            return result;
        }
        static double AreaOfCircle()
        {
            Circle r1 = new Circle();
            double result;
            Console.Write("Enter Radius: ");
            double rad = double.Parse(Console.ReadLine());
            result = r1.Area(rad);
            return result;
        }
        static double AreaOfSquare()
        {
            Square r1 = new Square();
            double result;
            Console.Write("Enter Length: ");
            double len = double.Parse(Console.ReadLine());
            result = r1.Area(len);
            return result;
        }
        static double AreaOfTriangle()
        {
            Triangle r1 = new Triangle();
            double result;
            Console.Write("Enter Height: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Enter Breadth: ");
            double b = double.Parse(Console.ReadLine());
            result = r1.Area(h, b);
            return result;
        }
    }
}
