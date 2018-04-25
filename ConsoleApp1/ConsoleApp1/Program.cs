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
            string path = @"C:\Users\Jamal\Desktop\Directory";
            string files = Path.GetFileName(path);

            foreach (string s in Directory.GetFiles(path, "*.txt").Select(Path.GetFileName))
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
