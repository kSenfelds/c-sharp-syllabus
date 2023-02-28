namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            int startAmount = int.Parse(Console.ReadLine());
            SavingsAccount savings = new SavingsAccount(startAmount);
            Console.WriteLine("Enter the annual interest rate :");
            int interestRate = int.Parse(Console.ReadLine());
            SavingsAccount._annualInterestRate = interestRate;
            Console.WriteLine("How long has the account been opened? :");
            int months = int.Parse(Console.ReadLine());

            for (int i=0; i<months; i++)
            {
                Console.WriteLine($"Enter amount deposited for month {i+1}");
                int deposited = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter amount withdrawn for month {i+1}");
                int withdrawn = int.Parse(Console.ReadLine());
                savings.Deposit(deposited);
                savings.Withdraw(withdrawn);
                savings.AddMonthlyRate();
            }
            savings.PrintInfo();

            Console.ReadKey();
        }
    }
}