using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class ChClass:AbClass
    {
        string message;
        public string ChProp { get=>message; set=>message=value; }

        public override string Welcome(string name)
        {
            return name;
        }
    }
}
