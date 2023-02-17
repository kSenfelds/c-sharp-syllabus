namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exit = 1;
            while (exit > 0)
            {
                Console.WriteLine("Please enter a number or anything else to exit the programm!");
                var input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);

                if (isNumber == false)
                {
                    exit = 0;
                }
                else if (number == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if (number % 2 == 0)
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