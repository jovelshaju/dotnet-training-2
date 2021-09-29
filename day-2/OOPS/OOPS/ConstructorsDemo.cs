using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //class Emp
    //{
    //    int eid;
    //    string ename;
    //    public Emp()
    //    {
    //        Console.WriteLine("-----Emp Constructor------");
    //        eid = -1;
    //        ename = "not given";
    //    }
    //    public virtual void Register()
    //    {
    //        Console.WriteLine("Enter ID:");
    //        eid = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Name:");
    //        ename = Console.ReadLine();
    //    }
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Employee ID: " + eid);
    //        Console.WriteLine("Employee name: " + ename);
    //    }
    //}

    //class Dev:Emp
    //{
    //    string domain;
    //    string projects;
    //    public Dev()
    //    {
    //        Console.WriteLine("---Dev Constructor---");
    //        domain = "not given";
    //        projects = "not given";
    //    }

    //    public override void Register()
    //    {
    //        base.Register();
    //        Console.WriteLine("Enter domain:");
    //        domain = Console.ReadLine();
    //        Console.WriteLine("Enter projects:");
    //        projects = Console.ReadLine();
    //    }
    //    public override void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("Domain: "+domain);
    //        Console.WriteLine("Projects: "+projects);
    //    }
    //}

    //Parameterised Constructor
    class ConstructorsDemo
    {
        int eid;
        string ename;
        public ConstructorsDemo(int id, string name)
        {
            Console.WriteLine("-----Emp Constructor------");
            eid = id;
            ename = name;
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter ID:");
            eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            ename = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.WriteLine("Employee ID: " + eid);
            Console.WriteLine("Employee name: " + ename);
        }
    }

    class Dev : ConstructorsDemo
    {
        string domain;
        string projects;
        public Dev(int id, string name, string dom, string proj): base(id, name)
        {
            Console.WriteLine("---Dev Constructor---");
            domain = dom;
            projects = proj;
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter domain:");
            domain = Console.ReadLine();
            Console.WriteLine("Enter projects:");
            projects = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain: " + domain);
            Console.WriteLine("Projects: " + projects);
        }
    }

    public class Customers{

        private int cid;
        private string cname;
        private string ccity;
        private readonly double cODLimit;
        private static double tax = 3.54;
        public Customers()
        {
            cid = 101;
            cname = "John";
            ccity = "Lahore";
            cODLimit = 560000.99;
        }

        public int Id
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Name
        {
            get { return cname; }
            set { cname = value; }
        }
        public string City
        {
            get { return ccity; }
            set { ccity = value; }
        }

        public double ODLimit
        {
            get { return cODLimit; }
        }

        public double Tax
        {
            get { return tax; }
        }

    }

    class CustomerNew
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime MStartDate { get; set; }
    }

}
