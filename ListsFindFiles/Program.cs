using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ListsFindFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a fruit");
                fruit.Add(Console.ReadLine());

            }

            
            fruit.Add("pineapple"); foreach (string fruititem in fruit)
            {
                Console.WriteLine($"fruit on the list {fruititem}");

            }
            int indexofpineapple = fruit.IndexOf("pineapple");
            Console.WriteLine($"pineapple is on index {indexofpineapple}");
            fruit[indexofpineapple] = "orange";
            fruit.Add("pineapple"); 
            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"fruit on the list {fruititem}");

            }
            fruit.RemoveAt(fruit.Count - 1); 
            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"trimmed fruit list {fruititem}");

            }




        }   
    }
}
