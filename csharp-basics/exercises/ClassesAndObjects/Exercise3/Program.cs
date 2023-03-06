namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuel = new FuelGauge();
            Odometer car1 = new Odometer(0, fuel);
            int distance = 1001;

            for (int i = 0; i < 70; i++)
            {
                fuel.IncrementFuel();
            }

            for (int i = 0; i < distance; i++)
            {
                if (car1.AbleToDrive())
                {
                    car1.IncrementMileage();
                    car1.Report();
                }
                else
                {
                    Console.WriteLine("Out of fuel!");
                    break;
                }
            }
        }
    }
}