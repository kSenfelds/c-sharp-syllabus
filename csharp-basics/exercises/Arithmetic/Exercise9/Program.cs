namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write metric to use metric system or eng to use english system");
            string system = Console.ReadLine();
            Console.WriteLine("Enter your weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateBMI(system, weight, height));
        }
        static string CalculateBMI (string system, double weight, double height)
        {
            if (system == "metric")
            {
                weight = weight / 0.45359237d;
                height = height / 0.0254d;
            }
            double BMI = weight * 703d / Math.Pow(height, 2);
            if (BMI < 18.5)
            {
                return "underweight";
            }
            else if (BMI > 25)
            {
                return "overweight";
            }
            else
            {
                return "OPTIMAL!";
            }
        }
    }
}