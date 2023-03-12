using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var listAlphabet = new List<string>
            {
                "Apple",
                "Banana",
                "Cactus",
                "Eagle",
                "Foobar",
                "Day",
                "June",
                "Hay",
                "Gun",
                "Ten"
            };

            listAlphabet.Insert(4, "BumbleBee");
            listAlphabet[listAlphabet.Count - 1] = "TenHaschanged";
            listAlphabet.Sort();
            Console.WriteLine(listAlphabet.Contains("Foobar"));

            foreach (var item in listAlphabet)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}