namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var input = int.Parse(Console.ReadLine());
            var intStack = new Stack<int>();
            intStack.Push(input);

            do
            {
                var numbers = intStack.Pop().ToString().ToCharArray();
                var result = 0d;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += Math.Pow(Convert.ToDouble(numbers[i].ToString()), 2d);
                }
                intStack.Push((int)result);
            }
            while (intStack.Peek() > 9);

            if (intStack.Peek() == 1)
            {
                Console.WriteLine("happy");
            }
            else
            {
                Console.WriteLine("not happy");
            }

            Console.ReadKey();
        }
    }
}