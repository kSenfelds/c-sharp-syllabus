namespace Exercise_7
{
    internal class Piglet
    {
        public void gamePiglet()
        {
            Console.WriteLine("Welcome to Piglet!");
            Random rand = new Random();
            int status = 1;
            int result = 0;
            int number = 0;
            do
            {
                number = rand.Next(0, 7);
                result += number;
                Console.WriteLine($"You rolled a {number}!");
                if (number == 0)
                {
                    Console.WriteLine("You got 0 points.");
                    status = 0;
                    break;
                }
                Console.WriteLine("Roll again?");
                var userChoice = Console.ReadKey();
                if (userChoice.KeyChar == 'n')
                {
                    Console.WriteLine($"You got {result} points.");
                    status = 0;
                }
            }
            while (status > 0);
        }
    }
}
