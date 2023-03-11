using System;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int wordsCount = 0;
            int charsCount = 0;

            foreach (string line in System.IO.File.ReadLines(@"..\..\lear.txt"))
            {
                counter++;
                charsCount += line.ToCharArray().Count();
                wordsCount += line.Split(' ', '\'').Count(x => x != "");
            }

            Console.WriteLine($"Lines: {counter}");
            Console.WriteLine($"Words: {wordsCount}");
            Console.WriteLine($"Chars: {charsCount}");

            Console.ReadKey();
        }
    }
}