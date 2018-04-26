using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            string path = @"C:\Users\Jamal\Desktop\Directory";
            string files = Path.GetFileName(path);

            Console.WriteLine("Enter file name:");

            foreach (string s in Directory.GetFiles(path, "*.txt").Select(Path.GetFileName))
            {

                Console.WriteLine(s);
            }
            Console.Write(":");
            input = Console.ReadLine();
            //Console.WriteLine(input);
            string text = System.IO.File.ReadAllText(@"C:\Users\Jamal\Desktop\Directory\" + input);




            Console.ReadLine();
        }
    }
}
