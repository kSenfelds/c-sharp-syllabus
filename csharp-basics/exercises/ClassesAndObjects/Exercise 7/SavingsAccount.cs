namespace Exercise_7
{
    internal class SavingsAccount
    {
        private decimal _balance;
        public static decimal _annualInterestRate;
        private decimal _deposited;
        private decimal _withdrawn;
        private decimal _interestEarned;

        public SavingsAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
            _withdrawn += amount;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            _deposited += amount;
        }

        public void AddMonthlyRate()
        {
            _interestEarned += _annualInterestRate / 12 * _balance;
            _balance += _annualInterestRate / 12 * _balance;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Total balance {string.Format("{0:0.00}", _balance)}EUR");
            Console.WriteLine($"Total amount deposited {string.Format("{0:0.00}", _deposited)}EUR");
            Console.WriteLine($"Total amount withdrawn {string.Format("{0:0.00}", _withdrawn)}EUR");
            Console.WriteLine($"Total interest earned {string.Format("{0:0.00}", _interestEarned)}EUR");
        }
    }
}
