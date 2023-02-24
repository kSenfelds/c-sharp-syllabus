namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int pcNumber = rand.Next(0, 100) +1;
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int userNumber = int.Parse(Console.ReadLine());
            if (pcNumber == userNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (pcNumber > userNumber)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {pcNumber}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {pcNumber}.");
            }
        }
    }
}