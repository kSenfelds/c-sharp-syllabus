using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            var unique = values.GroupBy(i => i).Where(x => x.Count() == 1).SelectMany(x => x).ToList();

            foreach (var value in unique)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}