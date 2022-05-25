using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }

        public Product (string name,double price,int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

    }
}
