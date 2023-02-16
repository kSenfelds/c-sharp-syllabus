namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a single digit number!");
            int numberA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a single digit number!");
            int numberB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a single digit number!");
            int numberC = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of numbers that You have entered is {numberA + numberB + numberC}");
        }
    }
}