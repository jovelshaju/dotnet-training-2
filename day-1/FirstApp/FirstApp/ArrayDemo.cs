using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class ArrayDemo
    {
        public static void Main2()
        {
            int[,] studMarks = new int[4, 5];
            int[] total = { 0, 0, 0, 0 };

            Console.WriteLine("Enter the details of students: \n====================");

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the Roll No. of Student-"+(i+1));
                studMarks[i, 0] = int.Parse(Console.ReadLine());
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine("Enter Student-{0}'s mark (out of 100) in sem-{0}",(i+1),j);
                    studMarks[i,j] = int.Parse(Console.ReadLine());
                    total[i] += studMarks[i, j];
                }
            }

            Console.WriteLine("\nStudents List\n=============");
            Console.WriteLine("Roll No. \t Sem1 \t Sem2 \t Sem3 \t Sem4 \t Total \t Percentage ");
            for(int i =0; i < 4; i++)
            {
                float percentage = (float)total[i] / 400 * 100;
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}",studMarks[i,0], studMarks[i, 1], studMarks[i, 2], studMarks[i, 3], studMarks[i, 4], total[i], percentage);

            }
            Console.ReadKey();
        }
    }
}
