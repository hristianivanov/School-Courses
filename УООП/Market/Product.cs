using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Product
    {
        public Product(string name, string barcode, double price, double amount)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Amount = amount;
        }

        public string Name { get; set; }
        public string Barcode { get; set; }
        public double Price{ get; set; }
        public double Amount { get; set; }


    }
}
