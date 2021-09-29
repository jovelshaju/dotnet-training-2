using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ListExcercise
{
    class Components
    {
        public SortedList ComponentList { get; set; }
        public Components()
        {
            ComponentList = new SortedList()
            {
                {"HDD", "Floppy Disk"},
                {"RAM", "Random Access Memory"},
                {"ROM", "Read Only Memory" },
                {"FDD", "Hard Disk" }
            };
        }

        public void Display()
        {
            Console.WriteLine("\n---Items in hashtable---");
            Console.WriteLine("Index \t Key \t Value");
            foreach (var k in ComponentList.Keys)
            {
                Console.WriteLine(ComponentList.IndexOfKey(k)+"\t"+ k + " \t " + ComponentList[k]);
            }
        }

        public void ChangeData()
        {
            Console.Write("Enter key: ");
            var key = Console.ReadLine();
            if (ComponentList.ContainsKey(key))
            {
                Console.Write("Enter New value: ");
                var newValue = Console.ReadLine();
                ComponentList[key] = newValue;
            }
            else
            {
                Console.WriteLine("\nInvalid Key!");
            }
        }
    }
}
