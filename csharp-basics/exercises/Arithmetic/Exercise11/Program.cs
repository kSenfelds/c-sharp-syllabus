namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(isMoranHarshad(input));
        }

        static string isMoranHarshad (int number)
        {
            int sumOfNumbers = 0;
            number = Math.Abs(number);
            int numberOriginal = Math.Abs(number);
            int[] digits = new int[number.ToString().Length];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = number % 10;
                number /= 10;
                sumOfNumbers+= digits[i];
            }
            if (numberOriginal % sumOfNumbers == 0)
            {
                if (isPrime(numberOriginal/sumOfNumbers) == true)
                {
                    return "M";
                }
                else
                {
                    return "H";
                }  
            }
            else
            {
                return "Neither";
            }
        }

        static bool isPrime (int number)
        {
            int a = 0;
            for (int i =1; i<=number; i++)
            {
                if(number%i == 0)
                {
                    a++;
                }
            }
            return a == 2;
        }
    }
}