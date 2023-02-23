namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNemo("I am finding Nemo !");
            FindNemo("Nemo is me");
            FindNemo("I Nemo am");
            FindNemo("I am not a NEmo!");
        }
        static void FindNemo(string sentence)
        {
            string[] words = sentence.Split(' ');
            if (words.Contains("Nemo"))
            {
                Console.WriteLine($"I found Nemo at {Array.IndexOf(words, "Nemo") + 1}");
            }
            else
            {
                Console.WriteLine("I can't find Nemo");
            }
        }
    }
}