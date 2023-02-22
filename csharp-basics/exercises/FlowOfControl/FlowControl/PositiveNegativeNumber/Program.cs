using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadKey();

            if (input.KeyChar != '0' && input.KeyChar != '-')
            {
                Console.WriteLine("Number is positive");
            }
            else if (input.KeyChar == '-') 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadKey();
            
        }
    }
}
