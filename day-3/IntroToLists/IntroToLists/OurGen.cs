using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLists
{
    class OurGen<T, U> where T:class where U:struct
    {
        T ourField1;
        U ourField2;
        public OurGen(T data1, U data2)
        {
            ourField1 = data1;
            ourField2 = data2;
        }
        public void Dislpay()
        {
            Console.WriteLine("Type of data1: {0} \t Data in data1: {1}",ourField1.GetType(),ourField1);
            Console.WriteLine("Type of data1: {0} \t Data in data2: {1}", ourField2.GetType(), ourField2);

        }
    }
}
