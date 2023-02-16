namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with Uppercase letters and Lowercase letters!");
            string input = Console.ReadLine();
            int upperCaseCounter = 0;
            for (int i=0; i<input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    upperCaseCounter++;
                }
            }
            Console.WriteLine(upperCaseCounter);
            
        }
    }
}