using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IntroToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //----ArrayList------
            //ArrayList names = new ArrayList()
            //{
            //    "John",
            //    "Sam",
            //    "Allen"
            //};

            //names.Sort();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //names.Insert(1, "Boyle");
            //Console.WriteLine("After Inserting at 1");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////----Normal List-----
            //ArrayList empList = new ArrayList()
            //{
            //    new Employee{Id = 1, Name = "John", Designation = "Developer", DoJ = new DateTime(day:1, month:2, year:2010), Salary = 85000.00},
            //    new Employee{Id = 2, Name = "Peter", Designation = "Manager", DoJ = new DateTime(day:5, month:5, year:2007), Salary = 125000.00},
            //    new Employee{Id = 3, Name = "Sam", Designation = "Tester", DoJ = new DateTime(day:23, month:12, year:2014), Salary = 55000.00},
            //    new Employee{Id = 4, Name = "Denna", Designation = "HR", DoJ = new DateTime(day:17, month:9, year:2009), Salary = 65000.00},
            //    new Employee{Id = 1, Name = "Leya", Designation = "Marketing Manager", DoJ = new DateTime(day:31, month:8, year:2012), Salary = 75000.00},
            //};
            //Console.WriteLine("----Employee List----");
            //Console.WriteLine("ID \t Name \t Designation \t DOJ \t Salary");
            //foreach (Employee employee in empList)
            //{
            //    Console.Write(employee.Id + " \t");
            //    Console.Write(employee.Name + " \t");
            //    Console.Write(" \t"+employee.Designation + " \t");
            //    Console.Write(" \t"+employee.DoJ.ToShortDateString() + " \t") ;
            //    Console.Write(" \t"+employee.Salary + " \t");
            //    Console.WriteLine("");
            //}

            //---Hashtable---
            //Hashtable hashtable = new Hashtable() 
            //{
            //    {"John","Doe" },
            //    {"Peter", "Quill" },
            //    {"Marco", "Polo" }
            //};

            //Console.WriteLine("---Items in hashtable---");
            //Console.WriteLine("Key \t Value");
            //foreach (var k in hashtable.Keys)
            //{
            //    Console.WriteLine(k + " \t "+ hashtable[k]);
            //}

            //---SortedList
            //SortedList sortedList = new SortedList()
            //{
            //    {"Marco","Doe" },
            //    {"Peter", "Quill" },
            //    {"John", "Polo" }
            //};

            //Console.WriteLine("---Items in hashtable---");
            //Console.WriteLine("Index \t Key \t Value");
            //foreach (var k in sortedList.Keys)
            //{
            //    Console.WriteLine(sortedList.IndexOfKey(k)+"\t"+ k + " \t " + sortedList[k]);
            //}

            //--Stack--
            //Stack stack = new Stack();
            //stack.Push("Ram");
            //stack.Push("Jasmin");
            //stack.Push("Radhika");
            //Console.WriteLine("Items in stack \n========");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //Console.WriteLine("After popping 1 item");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Last item: "+stack.Peek());

            //--Queue---
            //Queue queue = new Queue();
            //queue.Enqueue("Ram");
            //queue.Enqueue("Jasmin");
            //queue.Enqueue("Radhika");
            //Console.WriteLine("Items in stack \n========");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //queue.Dequeue();
            //Console.WriteLine("After popping 1 item");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Last item: " + queue.Peek());

            OurGen<Object, int> obj1 = new OurGen<Object, int>("sam",10);
            OurGen<string, double> obj2 = new OurGen<string, double>("Hello", 10.95);
            obj1.Dislpay();
            obj2.Dislpay();
            Console.ReadKey();
        }
    }
}
