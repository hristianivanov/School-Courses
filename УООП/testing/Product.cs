using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Product
    {
        public Product(string name, string productGroup, double price, double amount)
        {
            Name = name;
            ProductGroup = productGroup;
            Price = price;
            Amount = amount;
        }

        public string Name { get; set; }
        public string ProductGroup { get; set; }
        public double Price { get; set; }
        public static double Amount { get; set; }

        public static void IncreaseAmount()
        {
            if (Amount > 3)
            {
                Amount++;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Amount} бр. - {Price}";
        }
    }
}
