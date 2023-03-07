using System;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = @"C:\Users\Ršu\Source\Repos\c-sharp-syllabus\csharp-basics\exercises\Collections\Histogram\midtermscores.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var grades = readText.Split(' ').ToList();

            for (int i = 0; i < 100; i += 10)
            {
                string stars = new string('*', grades.Count(x => int.Parse(x) > i && int.Parse(x) < i + 10));
                Console.WriteLine($"{i.ToString().PadLeft(2, '0')}-{(i + 9).ToString().PadLeft(2, '0')}: {stars}");
            }

            Console.WriteLine($"100: {new string('*', grades.Count(x => int.Parse(x) == 100))}");

            Console.ReadKey();
        }
    }
}
