using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExcercise
{
    class KidLearning
    {
        public static List<string> days = new List<string>()
        { 
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        public static List<string> months = new List<string>()
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "November",
            "December"
        };

        public static List<string> fruits = new List<string>() { "Apple", "Banana", "Citrus", "Grapes", "Jackfruit", "Strawberry", "Raspberry", "Pineapple", "Mango"  };

        public static Dictionary<string,string> wordMeanings = new Dictionary<string, string>()
        {
            { "Stan","An extremely excessively enthusiastic and devoted fan" },
            { "Peoplekind","A gender-neutral alternative to mankind" },
            { "Buzzy","Something that generates excitement and gets people talking" },
            { "Climate emergency","a situation in which urgent action is required to reduce or halt climate change and avoid potentially irreversible environmental damage resulting from it" },
            { "Nomophobia","Fear or worry at the idea of being without your phone or unable to use it" },
        };

        public static void DisplayDays()
        {
            foreach (string item in days)
            {
                Console.WriteLine(item);
                Thread.Sleep(2000);
            }
        }

        public static void DisplayMonths()
        {
            foreach (string item in months)
            {
                Console.WriteLine(item);
                Thread.Sleep(2000);
            }
        }

        public static void DisplayFruits()
        {
            foreach (string item in fruits)
            {
                Console.WriteLine(item);
                //Thread.Sleep(2000);
            }
        }

        public static void DisplayWordMeaning()
        {
            foreach (var item in wordMeanings)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                //Thread.Sleep(2000);
            }
        }


    }
}
