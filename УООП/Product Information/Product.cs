using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Information
{
    class Product
    {
        private string type;
        private string name;
        private decimal price;
        public Product(string _type,string _name,decimal _price)
        {
            Type = _type;
            Name = _name;
            Price = _price;
        }
        public Product ()
        { 
        }
        public string Type
        {
            set { type = value; }
            get { return type; }
        }
        public string Name { 
          
            set { name = value; }
             get { return name; }
        }
        public decimal Price {
            set { price = value; }
            get { return price; }
        }
        public decimal Discount(decimal discount)
        {
            if (Type=="food")
            {
                Price = Price -( Price * (discount/100) );
           
            }
            return Price;
           
        }
       

    }
}
