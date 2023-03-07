using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            List<string> arrayAsList = new List<string>();
            arrayAsList = array.ToList();

            foreach (string item in arrayAsList)
            {
                Console.WriteLine(item);
            }

            HashSet<string> set = new HashSet<string>();
            set = array.ToHashSet();

            foreach (string value in set)
            {
                Console.WriteLine(value);
            }

            var dictionary = new Dictionary<string, string>();
            string[] values = { "Germany", "Germany", "Japan", "Germany", "Germany", "Germany", "USA" };

            for (int i = 0; i < values.Length; i++)
            {
                if (dictionary.ContainsKey(array[i]))
                {
                    continue;
                }
                else
                {
                    dictionary.Add(array[i], values[i]);
                }
            }

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value : {pair.Value}");
            }

            Console.ReadLine();
        }
    }
}