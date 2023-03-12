using System;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Regex.Replace(words[i], "ea", "*");
                Console.WriteLine(words[i]);
            }

            Console.ReadKey();
        }
    }
}