using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAnonymousFn
{
    public delegate void DelFn(string name);

    delegate bool DelSeniorityCheck(Emp emp);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //DelFn del = delegate (string username) {

            //    Console.WriteLine("Welcome to Anonymous " + username);
            //};
            //del(name);
            //del = (string n) => { Console.WriteLine("Hi there "+n); };
            //del("Peter");
            DelSeniorityCheck seniorityCheck = e => e.EExp >= 20;
            Emp emp = new Emp() { EId = 102, EName = "John", EDesignation = "Manager", EExp = 12 };
            if (seniorityCheck(emp))
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Not Senior");
            }

            Console.ReadKey();
        }   
    }
}
