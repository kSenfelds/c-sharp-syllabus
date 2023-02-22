using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(getCentury(2010));
            Console.ReadKey();
        }
        static string getCentury (int year)
        {
            if (year >=1000 && year <=2010)
            {
                if (year == 1000)
                {
                    return "10th century";
                }
                else if (year > 1000 && year < 1101)
                {
                    return "11th century";
                }
                else if (year > 1100 && year < 1201)
                {
                    return "12th century";
                }
                else if (year > 1200 && year < 1301)
                {
                    return "13th century";
                }
                else if (year > 1300 && year < 1401)
                {
                    return "14th century";
                }
                else if (year > 1400 && year <1501)
                {
                    return "15th century";
                }
                else if (year > 1500 && year < 1601)
                {
                    return "16th century";
                }
                else if (year > 1600 && year < 1701)
                {
                    return "17th century";
                }
                else if (year > 1700 && year < 1801)
                {
                    return "18th century";
                }
                else if (year > 1800 && year < 1901)
                {
                    return "19th century";
                }
                else if (year > 1900 && year < 2001)
                {
                    return "20th century";
                }
                else 
                {
                    return "21st century";
                }

            }
            else
            {
                return "Invalid year entered";
            }
        }
    }
}
