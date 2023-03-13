using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; }
        public bool HasProducts { get; }
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
            Money moneyInMachine = new Money();
            var totalEuros = Amount.Euros + amount.Euros;
            var totalCents = Amount.Cents + amount.Cents;
            moneyInMachine.Euros = totalEuros + totalCents / 100;
            moneyInMachine.Cents = totalCents % 100;
            Amount = moneyInMachine;

            return Amount;
        }

        private void DeleteAmount()
        {
            Amount = new Money(0, 0);
        }

        private Money CalculateChange(Money price)
        {
            Money change = new Money();
            var moneyIn = Amount.Euros * 100 + Amount.Cents;
            var moneyPrice = price.Euros * 100 + price.Cents;
            var totalchange = moneyIn - moneyPrice;
            change.Cents = totalchange % 100;
            change.Euros = totalchange / 100;
            Amount = change;

            return Amount;
        }

        public Money ReturnMoney()
        {
            Console.WriteLine($"Your change {Amount}");

            return Amount;
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

        public void BuyProduct(string name)
        {
            bool found = false;
            Product selectedProduct = Products.FirstOrDefault(x => x.Name == name ? found = true : found = false);
            if (found && selectedProduct.Available > 0)
            {
                if (selectedProduct.CanAfford(Amount))
                {
                    Console.WriteLine($"Bought {selectedProduct.Name} for {selectedProduct.Price}!");
                    selectedProduct.Available--;
                    CalculateChange(selectedProduct.Price);
                    ReturnMoney();
                    DeleteAmount();
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                }
            }
            else
            {
                Console.WriteLine("Product not found or out of stock!");
            }
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < Products.Length - 1)
            {
                Products[productNumber] = new Product { Available = amount, Name = name, Price = price.HasValue ? price.Value : new Money() };

                return true;
            }
            else
            {
                Console.WriteLine("Product not found");

                return false;
            }
        }

        public override string ToString()
        {
            var result = "";

            for (int i = 0; i < Products.Length; i++)
            {
                result += Products[i].Name + "\n";
            }

            return result;
        }
    }
}