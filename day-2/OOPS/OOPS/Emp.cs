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
    class Emp
    {
        int eid;
        string ename;
        public Emp(int id, string name)
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

    class Dev : Emp
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

}
