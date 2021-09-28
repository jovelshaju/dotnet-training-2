using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class GotoDemo
    {
        static void Main2()
        {
            string userName;

        getUserName:
            Console.WriteLine("Enter username:");
            userName = Console.ReadLine();
            if(userName.Length < 6)
            {
                Console.WriteLine("Length must be atleast 6 characters");
                goto getUserName;
            }
        }
    }
}
