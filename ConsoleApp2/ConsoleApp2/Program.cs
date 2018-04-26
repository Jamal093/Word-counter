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
            //string files = Path.GetFileNameWithoutExtension(path);

            Console.WriteLine("Enter (.txt) file name listed below:");

            foreach (string s in Directory.GetFiles(path, "*.txt").Select(Path.GetFileNameWithoutExtension))
            {

                Console.Write(s);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write(":");
            input = Console.ReadLine();
            //Console.WriteLine(input);
            string text = File.ReadAllText(@"C:\Users\Jamal\Desktop\Directory\" + input + ".txt");


            //Console.WriteLine(text);

            int count = text.Split(' ').Length;
            Console.WriteLine("There are " + count + " word(s) in " + input + ".txt file.");
            Console.ReadLine();


        }
    }
}
