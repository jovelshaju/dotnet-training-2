using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTypesDemo
{
    class Emp
    {
        private int id;
        private string name;
        private string desig;

        public string EDesig
        {
            get { return desig; }
            set { desig = value; }
        }

        public string EName
        {
            get { return name; }
            set { name = value; }
        }

        public int EId
        {
            get { return id; }
            set { id = value; }
        }

        public Emp(int eid, string ename, string edesig)
        {
            id = eid;
            name = ename;
            desig = edesig;
        }

    }
}
