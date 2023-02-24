namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(is15(number1, number2));
        }

        static bool is15 (int number1, int number2)
        {
            return number1 == 15 || number2 == 15 || number1 + number2 == 15 || number1 - number2 == 15;
        }
    }
}