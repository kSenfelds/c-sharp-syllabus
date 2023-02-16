namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 10;
            int result = 1;
            for (int i = startNumber; i < endNumber; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}