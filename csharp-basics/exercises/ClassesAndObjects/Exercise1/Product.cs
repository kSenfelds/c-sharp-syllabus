namespace Exercise1
{
    internal class Product
    {
        private decimal _price;
        private int _amount;
        private string _name;

        public Product(string name, decimal priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_price} EUR, amount {_amount} units.");
        }

        public int ChangeAmount(int newAmount)
        {
            _amount = newAmount;
            return _amount;
        }

        public decimal ChangePrice(decimal newPrice)
        {
            _price = newPrice;
            return _price;
        }
    }
}
