namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Ŗocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "male");
            Dog molly = new Dog("Molly", "male");
            Dog coco = new Dog("Coco", "male");

            max.SetParents(lady, rocky);
            coco.SetParents(molly, buster);
            rocky.SetParents(molly, sam);
            buster.SetParents(lady, sparky);

            Console.WriteLine($"{coco._name}'s father is {coco.GetFathersName()}");
            Console.WriteLine($"{sparky._name}'s father is {sparky.GetFathersName()}");
            Console.WriteLine($"{coco._name} has same mother as {rocky._name}? - {coco.HasSameMother(rocky)}");

            Console.ReadKey();
        }
    }
}