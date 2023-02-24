namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word for Reversecase :");
            string input = Console.ReadLine();
            ReverseCase(input);
        }
        static void ReverseCase(string sentence)
        {
            string[] chars = new string[sentence.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(sentence[i]))
                {
                    chars[i] = sentence[i].ToString().ToUpper();
                }
                else if (char.IsUpper(sentence[i]))
                {
                    chars[i] = sentence[i].ToString().ToLower();
                }
                else
                {
                    chars[i] = sentence[i].ToString();
                }
            }
            Console.WriteLine(String.Join("", chars));
        }
    }
}