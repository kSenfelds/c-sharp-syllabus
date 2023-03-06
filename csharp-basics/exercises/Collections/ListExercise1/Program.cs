using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            //TODO: Add 5 colors to list
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.AddRange(new string[] { "Color1", "Color2", "Color3", "Color4", "Color5" });

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
