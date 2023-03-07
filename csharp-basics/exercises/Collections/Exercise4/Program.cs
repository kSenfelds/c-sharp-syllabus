namespace Exercise4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            bool hasName = true;
            List<string> names = new List<string>();
            while (hasName)
            {
                Console.WriteLine("Enter name");
                var input = Console.ReadLine();
                names.Add(input);
                if (input.Length == 0)
                {
                    hasName = false;
                    var unique = names.Distinct().ToList();
                    Console.WriteLine($"Unique name list contains: {string.Join(" ", unique)}");
                }
            }

            Console.ReadKey();
        }
    }
}