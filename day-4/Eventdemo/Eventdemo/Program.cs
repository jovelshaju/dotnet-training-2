using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.MyEvent += new MyDel(calculator.Add);
            calculator.MyEvent += new MyDel(calculator.Div);
            calculator.RaiseEvent(20, 4);
            Console.ReadKey();
        }
    }
}
