namespace BankAccount
{
    internal class Account
    {
        private string _name;
        private decimal _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            return _balance > 0 ? $"{_name}, ${string.Format("{0:0.00}", _balance)}" : $"{_name}, -${string.Format("{0:0.00}", _balance * -1)}";
        }
    }
}
