namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kristaps = new Student("Kristaps", "Senfelds", "Nākotne", 1, 100.05);
            Person rihards = new Employee("Rihards-Reinis", "Senfelds", "Jelgava", 2, "BOSS!");
            kristaps.Display();
            rihards.Display();
        }
    }
}