using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroTofileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //File;
            //string path = "C:\\Users\\jshaju\\Documents\\Training Projects\\soti\\soti-back-end-aug2021\\dotnet-training-2\\day-4\\IntroTofileHandling\\IntroTofileHandling\\Hello.txt";
            //if (File.Exists(path))
            //{
            //    var data = File.ReadAllText(path);
            //    Console.WriteLine(data);
            //    File.WriteAllText(path, "Cool , right");
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}

            try
            {
                string mPath = "C:\\";
                Console.WriteLine("Enter directory to be created: ");
                string cPath = Console.ReadLine();
                string path = mPath + cPath;
                if (File.Exists(path))
                {
                    Console.WriteLine("This folder already exists!");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Folder Created");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
            finally
            {
                Console.ReadKey();

            }
        }
    }
}
