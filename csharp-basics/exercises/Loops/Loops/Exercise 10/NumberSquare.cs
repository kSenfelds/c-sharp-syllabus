namespace Exercise_10
{
    internal class NumberSquare
    {
        public void CreateNumberSquare()
        {
            Console.WriteLine("enter min value");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("enter max value");
            int max = int.Parse(Console.ReadLine());
            int length = max + 1 - min;
            for (int row = min; row <= max; row++)
            {
                for (int i = row; i <= max; i++)
                {
                    Console.Write(i);
                }

                for (int i = min; i < row; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
