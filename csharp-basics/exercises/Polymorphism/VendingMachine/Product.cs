using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Product
    {
        ///<summary>Gets or sets the available amount of product.</summary>
        public int Available { get; set; }
        ///<summary>Gets or sets the product price.</summary>
        public Money Price { get; set; }
        ///<summary>Gets or sets the product name.</summary>
        public string Name { get; set; }

        public Product(int available, Money price, string name)
        {
            Available = available;
            Price = price;
            Name = name;
        }

        public bool IsAvailable()
        {
            if (Available > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Out of stock!");
                return false;
            }
        }

        public void DecreaseCount()
        {
                Available--;
        }

        public bool CanAfford(Money amount) 
        {
            if (Price.Euros<amount.Euros || (Price.Euros==amount.Euros && Price.Cents <= amount.Cents))
            {
                return true;
            }
            return false;
        }
    }
}
