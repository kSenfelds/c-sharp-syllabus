namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odometer car1 = new Odometer(0, 0);
            int distance = 1001;
            car1.FillTank(70);
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