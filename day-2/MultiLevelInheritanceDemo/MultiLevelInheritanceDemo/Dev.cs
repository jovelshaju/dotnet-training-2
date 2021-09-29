using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    class Dev:Emp
    {
        readonly string domain;

        public Dev(int id, string name, string domain):base(id, name)
        {
            this.domain = domain;
        }
    }
}
