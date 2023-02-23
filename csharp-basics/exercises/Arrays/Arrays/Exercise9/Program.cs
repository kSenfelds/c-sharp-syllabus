namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "kristaps", "RIHARDS", "Reinis", "kRistiAnA" };
            foreach (string name in names)
            {
                Console.Write(name +" ");
            }
            Console.WriteLine();
            string[] cappedNames = CapMe(names);
            foreach (string name in cappedNames)
            {
                Console.Write(name + " ");
            }

            Console.ReadKey();
        }
        static string[] CapMe(string[] words)
        {
            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                result[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return result;
        }
    }
}