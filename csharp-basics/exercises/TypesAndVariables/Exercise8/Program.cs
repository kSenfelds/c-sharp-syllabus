namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter minutes");
            int minutes = Int32.Parse(Console.ReadLine());
            int minutesInYear = 60 * 24 * 365;
            int minutesInDay = 60 * 24;
            int years = minutes / minutesInYear;
            int minutesToDays = minutes % minutesInYear;
            int days = minutesToDays / minutesInDay;

            Console.WriteLine($"it's {years} years and {days} days");
        }
    }
}