using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shop
{
    internal class Product
    {
        private string name;
        private double price;
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
            IsOnPromotion = false;
        }

        public Product(string name, double price, bool isOnPromotion)
        {
            this.Name = name;
            this.Price = price;
            IsOnPromotion = isOnPromotion;
        }

        public string Name
        {
            get => this.name;
            set
            {
                string pattern = @"^[\w]+[\d]+$";
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(value) && value.Length<3)
                {
                    throw new ArgumentException("Invalid product name!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get => this.price;
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                this.price = value;
            }
        }

        public bool IsOnPromotion { get; set; }

        public override string ToString()
        {
            string promotion = IsOnPromotion ? "YES" : "NO";
            return $"Product -> {Name} with price {Price:F2}. On promotion {promotion}";
        }

    }
}
