using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignKeyInEF
{
    class Program
    {
        static Day14DBEntities db;
        static void Main(string[] args)
        {
            db = new Day14DBEntities();

            var query = from t1 in db.Emps
                        join t2 in db.Depts
                        on t1.DeptID equals t2.DId
                        select new
                        {
                            t1.EId,
                            t1.EFName,
                            t1.ELName,
                            t2.DName
                        };

            foreach (var e in query)
            {
                Console.WriteLine(e.EId);
                Console.WriteLine(e.EFName);
                Console.WriteLine(e.ELName);
                Console.WriteLine(e.DName);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }

    }
}
