using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; }

        public bool HasProducts { get; }
        private Money _total = new Money();
        private Money _change = new Money();
        public Money Amount { get; set; }
        public Product[] Products { get; set; }
        private List<Product> _products = new List<Product>();

        public VendingMachine(string manufacturer, bool hasProducts, Money amount, Product[] products)
        {
            Manufacturer = manufacturer;
            HasProducts = hasProducts;
            Amount = amount;
            Products = products;
        }

        public Money InsertCoin(Money amount)
        {
            if (amount.Euros != 1.00 || amount.Euros != 2.00 || amount.Cents != 10 || amount.Cents != 20 || amount.Cents != 50)
            {
                Console.WriteLine("Wrong coin!");
            }
            else
            {
                _total.Euros += amount.Euros;
                _total.Cents += amount.Cents;
                var change = _total.Cents % 100;
                _total.Euros += _total.Cents / 100;
                _total.Cents = change;
                Amount = _total;
            }
            return _total;
        }
        private void DeleteAmounts()
        {
            _total.Euros = 0;
            _total.Cents = 0;
            Amount = _total;
            _change.Cents = 0;
            _change.Euros = 0;
        }

        public Money ReturnMoney()
        {
            return _change;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            int productsLength = Products.Length;
            _products.AddRange(Products);
            _products.Add(new Product(count, price, name));
            Products = _products.ToArray();
            _products.Clear();
            return productsLength < Products.Length;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            bool found = false;
            Product selectedProduct = Products.FirstOrDefault(x => x.Name == name ? found = true : found = false);
            if (found && selectedProduct.IsAvailable())
            {
                if (selectedProduct.CanAfford(Amount))
                {
                    var moneyIn = Amount.Euros * 100 + Amount.Cents;
                    var moneyPrice = selectedProduct.Price.Euros * 100 + selectedProduct.Price.Cents;
                    var change = moneyIn - moneyPrice;

                    _change.Cents = change % 100;
                    _change.Euros = change / 100;
                    ReturnMoney();
                    DeleteAmounts();
                    selectedProduct.DecreaseCount();

                    return true;
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Product not found!");
                return false;
            }
        }
    }
}
