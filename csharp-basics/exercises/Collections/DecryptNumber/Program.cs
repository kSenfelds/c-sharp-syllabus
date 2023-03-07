using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var dictionary = new Dictionary<int, char>
            {
                {1, '!' },
                {2, '@' },
                {3, '#' },
                {4, '$' },
                {5, '%' },
                {6, '^' },
                {7, '&' },
                {8, '*' },
                {9, '(' },
                {0, ')' }
            };

            foreach (var c in cryptedNumbers)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(dictionary.First(x => x.Value == c[i]).Key);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}