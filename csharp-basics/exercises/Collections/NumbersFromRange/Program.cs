using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();

            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var result = new List<int>();
            result = numbers.Where(x => x > 30 && x < 100).ToList();

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}