using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    class HerbalProduct : Product
    {
        private string hpHerbsUsed;
        private DateTime hpMfDate;
        private DateTime hpExpDate;

        public DateTime ExpDate
        {
            get { return hpExpDate; }
            set { hpExpDate = value; }
        }


        public DateTime MfDate
        {
            get { return hpMfDate; }
            set { hpMfDate = value; }
        }

        public string HerbsUsed
        {
            get { return hpHerbsUsed; }
            set { hpHerbsUsed = value; }
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Herbs Used: ");
            HerbsUsed = Console.ReadLine();
            Console.WriteLine("Enter Manufactured Date: ");
            MfDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Expiry Date: ");
            ExpDate = DateTime.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Herbs Used: {0}", HerbsUsed);
            Console.WriteLine("Herbs Used: {0}", MfDate.ToShortDateString());
            Console.WriteLine("Herbs Used: {0}", ExpDate.ToShortDateString());

        }
    }
}
