namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many single digit numbers would you like to sum?");
            int count = Int32.Parse(Console.ReadLine());
            int result = 0;
            while (count > 0)
            {
                Console.WriteLine("Enter a single digit number");
                count--;
                result +=Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum of numbers that You have entered is {result}");
        }
    }
}