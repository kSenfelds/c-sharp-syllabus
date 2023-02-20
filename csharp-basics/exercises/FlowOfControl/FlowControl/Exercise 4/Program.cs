namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 6");
            var input = Console.ReadLine();
            int dayNumber;
            bool isNumber = int.TryParse(input, out dayNumber);
            if (isNumber)
            {
                Console.WriteLine(nestedIf(dayNumber));
                Console.WriteLine(switchCaseDefault(dayNumber));
            }
            else
            {
                Console.WriteLine("Error, not a number!");
            }
        }
        static string nestedIf (int dayNumber)
        {
                if (dayNumber >= 0 && dayNumber <= 6)
                {
                    if (dayNumber == 0)
                    {
                        return "Sunday";
                    }
                    else if (dayNumber == 1)
                    {
                        return "Monday";
                    }
                    else if (dayNumber == 2)
                    {
                        return "Tuesday";
                    }
                    else if (dayNumber == 3)
                    {
                        return "Wednesday";
                    }
                    else if (dayNumber == 4)
                    {
                        return "Thursday";
                    }
                    else if (dayNumber == 5)
                    {
                        return "Friday";
                    }
                    else 
                    {
                        return "Saturday";
                    }
                }
                else
                {
                    return "Not a valid day";
                }

        }
        static string switchCaseDefault (int dayNumber)
        {
            switch (dayNumber)
            {
                case 0: return "Sunday"; 
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                default: return "Not a valid day";
            }
        }
    }
}