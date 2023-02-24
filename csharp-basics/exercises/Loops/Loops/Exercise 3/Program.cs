namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which position out of 20 random numbers you want to know?");
            int position = int.Parse(Console.ReadLine());
            int[] randomNumbers = new int[20];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Random random = new Random();
                randomNumbers[i] = random.Next(0, 100);
            }
            Console.WriteLine($"The number in position {position} is : {randomNumbers[position - 1]}");
        }
    }
}