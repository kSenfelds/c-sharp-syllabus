namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exit = 1;
            while (exit > 0)
            {
                Console.WriteLine("Please enter a number or exit to exit the programm!");
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    exit = 0;
                }
                else if (int.Parse(input) % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
           
            Console.WriteLine("bye!");

        }
    }
}