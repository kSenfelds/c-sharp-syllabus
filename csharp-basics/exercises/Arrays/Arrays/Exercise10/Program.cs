namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            Console.WriteLine(CountPosSumNeg(numbers)[0]);
            Console.WriteLine(CountPosSumNeg(numbers)[1]);
        }
        static int[] CountPosSumNeg(int[] numbers)
        {
            int[] result = new int[2];
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    result[1] += numbers[i];
                }
                else
                {
                    result[0]++;
                }
            }

            return result;
        }
    }
}