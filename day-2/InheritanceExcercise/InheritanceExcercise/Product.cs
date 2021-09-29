using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    public class Product
    {
        private int pId;
        private string pName;
        private int pPrice;

        public int Price
        {
            get { return pPrice; }
            set { pPrice = value; }
        }

        public string Name
        {
            get { return pName; }
            set { pName = value; }
        }

        public int Id
        {
            get { return pId; }
            set { pId = value; }
        }

        public virtual void Register()
        {
            Console.Write("Enter Product ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            Name = Console.ReadLine();
            Console.Write("Enter Product Price:");
            Price = int.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine("Product ID: {0}", Id);
            Console.WriteLine("Product Name: {0}", Name);
            Console.WriteLine("Product Price: {0}", Price);

        }

    }
}
