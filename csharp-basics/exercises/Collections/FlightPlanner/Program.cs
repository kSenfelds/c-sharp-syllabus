using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"..\..\flights.txt";
        private static void Main(string[] args)
        {
            var flights = new Dictionary<string, List<string>>();
            var readText = File.ReadAllLines(Path);

            foreach (var s in readText)
            {
                if (s.Length > 0)
                {
                    string[] keyValue = s.Split(new string[] { "->" }, StringSplitOptions.None);
                    if (flights.ContainsKey(keyValue[0].Trim()))
                    {
                        flights[keyValue[0].Trim()].Add(keyValue[1].Trim());
                    }
                    else
                    {
                        flights.Add(keyValue[0].Trim(), new List<string>() { keyValue[1].Trim() });
                    }
                }
            }

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadKey().KeyChar;

            if (input == '1')
            {
                foreach (var flight in flights)
                {
                    Console.WriteLine($"{flight.Key}");
                }

            }
            Console.WriteLine("To enter start city press 1");
            input = Console.ReadKey().KeyChar;

            if (input == '1')
            {
                var citiesVisited = new List<string>();
                Console.WriteLine("enter a city");
                var city = Console.ReadLine();
                citiesVisited.Add(city);
                bool hasReturned = false;

                do
                {
                    Console.WriteLine("Available flights :");
                    foreach (var value in flights[city])
                    {
                        Console.Write(value + "  ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("enter next destination:");
                    city = Console.ReadLine();
                    citiesVisited.Add(city);

                    if (citiesVisited.First() == citiesVisited.Last())
                    {
                        Console.WriteLine("Welcome back - the cities that you have visited :");
                        foreach (var value in citiesVisited)
                        {
                            Console.WriteLine(value);
                        }
                        hasReturned = true;
                    }
                } while (!hasReturned);
            }

            Console.ReadKey();
        }
    }
}