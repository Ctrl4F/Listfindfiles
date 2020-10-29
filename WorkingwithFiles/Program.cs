using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingwithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\users\opilane\data\test.txt";
            List<string> datafromfile = File.ReadAllLines(filepath).ToList();
            
            foreach(string line in datafromfile)
            {
                Console.WriteLine($"Data from files {line}");
            }

            datafromfile.Add("grappes");
            File.WriteAllLines(filepath, datafromfile);
        }
    }
}
