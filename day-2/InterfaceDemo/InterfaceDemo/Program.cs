using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class IntrfaceDemo : Interface1, Interface2
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void Interface1.Display()
        {
            throw new NotImplementedException();
        }

        void Interface2.Display()
        {
            throw new NotImplementedException();
        }

        void Interface2.Second()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 int1 = Interface1();
            int1.Display();
        }
    }
}
