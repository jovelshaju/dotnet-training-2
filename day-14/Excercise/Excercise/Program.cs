using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        static OurExcercise9DBEntities db;
        static void Main(string[] args)
        {
            db = new OurExcercise9DBEntities();

            var query = from t1 in db.Books
                        join t2 in db.Categories
                        on t1.CatID equals t2.CId
                        select new
                        {
                            t1.BId,
                            t1.BName,
                            t1.AName,
                            t1.BPrice,
                            t2.CName
                        };

            foreach (var b in query)
            {
                Console.WriteLine($"ID: {b.BId}");
                Console.WriteLine($"Title: {b.BName}");
                Console.WriteLine($"Author: {b.AName}");
                Console.WriteLine($"Cateogry: {b.CName}");
                Console.WriteLine($"Price: {b.BPrice}");
                
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
