namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("e");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            set.Clear();
            set.Add("a");
            set.Add("a");
            set.Add("a");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}