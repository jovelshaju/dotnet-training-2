using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    class AppDev:Dev
    {
        string osType;
        public AppDev(int id, string name, string domain, string osType):base(id, name, domain)
        {
            this.osType = osType;
        }
    }
}
