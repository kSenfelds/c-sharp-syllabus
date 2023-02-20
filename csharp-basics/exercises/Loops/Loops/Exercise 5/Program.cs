namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string secondWord = Console.ReadLine();
            string dots = "";
            for (int i = 0; i< 30-firstWord.Length - secondWord.Length; i++)
            {
                dots += ".";
            }
            Console.WriteLine(firstWord + dots + secondWord);
            Console.WriteLine(firstWord.Length + dots.Length + secondWord.Length);
        }
    }
}