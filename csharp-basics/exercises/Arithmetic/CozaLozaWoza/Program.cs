namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowestNumber = 1;
            int highestNumber = 110;
            int numbersPerLine = 11;
            int counter = 1;
            string result = "";
            for (int i =lowestNumber; i <= highestNumber; i++)
            {
                if (i == highestNumber)
                {
                    Console.WriteLine(result + CozaLozaWoza(i));
                }
                else if (counter <= numbersPerLine)
                {
                    result += CozaLozaWoza(i) + " ";
                    counter++;
                }
                
                else 
                {
                    Console.WriteLine(result);
                    counter = 0;
                    result = CozaLozaWoza(i) + " ";
                }        
            }     
        }
        static string CozaLozaWoza (int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "CozaLoza";
            }
            else if (number %7==0 && number % 3 == 0)
            {
                return "CozaWoza";
            }
            else if (number % 7 == 0)
            {
                return "Woza";
            }
            else if (number % 5 == 0)
            {
                return "Loza";
            }
            else if (number%3 == 0)
            {
                return "Coza";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}