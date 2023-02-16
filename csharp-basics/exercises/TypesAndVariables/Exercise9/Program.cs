namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input distance in meters");
            int distanceMeters = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input hours");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input minutes");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input seconds");
            int seconds = int.Parse(Console.ReadLine());

            decimal distanceMiles = (decimal)distanceMeters / 1609; 
            int totalSeconds = hours*60*60+minutes*60+seconds;
            decimal totalHours = (decimal)totalSeconds / 3600;

            decimal metersPerSecond = Math.Round((decimal)distanceMeters / totalSeconds, 8);
            decimal kilometersPerHour =Math.Round((decimal)(distanceMeters / totalHours / 1000), 8) ;
            decimal milesPerHour = Math.Round((decimal)distanceMiles / totalHours, 8);

            Console.WriteLine($"Your speed in meters/second is {metersPerSecond}");
            Console.WriteLine($"Your speed in km/h is {kilometersPerHour}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHour}");
        }
    }
}