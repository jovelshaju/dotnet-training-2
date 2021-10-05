using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> studentList = new SortedList<int, string>()
            {
                {101, "Johnny" },
                {231, "Sara" },
                {157, "Kevin" },
                {423, "May" },
                {333, "Rose" },
            };

            SortedList<int, string> nw_list;
            
            var sorted=studentList.OrderByDescending(item => item.Value).ToList();

            //nw_list = sorted.ToList<int,string>();
            //Console.WriteLine(sorted.GetType());
            Console.WriteLine("Student details sorted by Name\n=========");
            Console.WriteLine("ID \tName\n-- \t----");
            foreach (var item in sorted)
            {
                Console.WriteLine("{0} \t{1}",item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
