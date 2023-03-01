namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            Testpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            Testpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            Student student1= new Student();
            Student student2= new Student();

            string[] test = student1.TestsTaken;
            foreach(string s in test)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}