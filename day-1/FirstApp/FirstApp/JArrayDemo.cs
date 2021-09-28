using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class JArrayDemo
    {
        static void Main2()
        {
            Console.Write("Enter no. of employees: ");
            int numEmp = int.Parse(Console.ReadLine());
            int[][] empArray = new int[numEmp][];
            for (int i=0; i < numEmp; i++)
            {
                Console.Write("Enter number of working days of Employee-{0} :", (i + 1));
                empArray[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < empArray[i].Length; j++)
                {
                    Console.Write("Enter salary in day-{0} : ", (j + 1));
                    empArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEmployees details:\n==========");
            for(int i=0; i < numEmp; i++)
            {
                Console.WriteLine("Employee-" + (i + 1));
                int total = 0;
                for(int j = 0; j < empArray[i].Length; j++)
                {
                    Console.WriteLine("Day-{0} :  {1}", (j + 1), empArray[i][j]);
                    total += empArray[i][j];
                }
                Console.WriteLine("Total Salary : " + total);
            }

            Console.ReadKey();
        }
        
    }
}
