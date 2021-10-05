using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesignPatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj1 = new OurClass();
            //OurClass obj2 = new OurClass();
            //OurClass obj3 = new OurClass();

            //obj1.Welcome("John");
            //obj2.Welcome("Elizabeth");
            //obj3.Welcome("Rachel");

            SingleTonDemo obj1 = SingleTonDemo.GetInstance;
            obj1.Welcome("John");

            SingleTonDemo obj2 = SingleTonDemo.GetInstance;
            obj2.Welcome("Elizabeth");

            SingleTonDemo obj3 = SingleTonDemo.GetInstance;
            obj3.Welcome("Rachel");

            Console.ReadKey();

        }
    }

    //Non-singleton Class
    class OurClass
    {
        private static int count=0;

        public static int Count
        {
            get { return count; }
        }

        public OurClass()
        {
            count++;
            Console.WriteLine("No. of instances: "+count);
        }
        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to design pattern "+name);
        }
    }

    //SingleTon Class
    sealed class SingleTonDemo
    {
        private static int numInstances = 0;
        private static SingleTonDemo instance=null;

        public SingleTonDemo()
        {
            numInstances++;
        }

        public static SingleTonDemo GetInstance
        { get 
            {
                if (numInstances == 0)
                {
                    instance = new SingleTonDemo();
                }
                Console.WriteLine("No. of instances: " + numInstances);
                return instance;
            }
        }

        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to design pattern " + name);
        }
    }
}
