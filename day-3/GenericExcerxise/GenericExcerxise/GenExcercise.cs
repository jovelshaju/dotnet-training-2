using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericExcerxise
{
    class GenExcercise
    {
        public SortedList<int, Customer> CustomerList { get; set; }
        public GenExcercise()
        {
            CustomerList = new SortedList<int, Customer>() 
            {
                {101, new Customer(){CName="Abraham", CCity="Washington D C", CODLimit=25000.00} },
                {121, new Customer(){CName="Carl", CCity="Bronx", CODLimit=10000.00} },
                {281, new Customer(){CName="Lincoln", CCity="California", CODLimit=125000.00} },
                {311, new Customer(){CName="Chris", CCity="Las Vegas", CODLimit=2500.00} },
                {239, new Customer(){CName="Damon", CCity="New York", CODLimit=35000.00} },
            };
        }

        public void Display()
        {
            Console.WriteLine("\n---Items in hashtable---");
            Console.WriteLine("Index \t Key \t Value");
            foreach (var k in CustomerList.Keys)
            {
                Console.WriteLine(CustomerList.IndexOfKey(k) + "\t" + k + " \t " + CustomerList[k].Display());
            }
        }

        public void DeleteData()
        {
            Console.Write("Enter key: ");
            var key = int.Parse(Console.ReadLine());
            if (CustomerList.ContainsKey(key))
            {
                CustomerList.Remove(key);
            }
            else
            {
                Console.WriteLine("\nInvalid Key!");
            }
        }
    }
}
