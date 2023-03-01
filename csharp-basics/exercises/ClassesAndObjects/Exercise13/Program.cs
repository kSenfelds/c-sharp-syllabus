namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FruitSmoothie s1 = new FruitSmoothie(new string[] { "Blueberries", "Strawberries", "Banana", "Raspberries" });
            decimal price = s1.GetPrice();
            string name = s1.GetName();
            Console.WriteLine($"{name} price is : {price}");
        }
    }
}