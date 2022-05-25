using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes
{
    class Meal
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public List<Product> Products { get; set; }

        public Meal(string name,string type,List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.Products = products;
        }


    }
}
