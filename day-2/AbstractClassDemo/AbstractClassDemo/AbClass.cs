using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class AbClass
    {

        public string MyProperty { get; set; }

        public AbClass()
        {
            Console.WriteLine("Abstract Class Constructor");
        }
        public abstract string Welcome(string name);
        
    }
}
