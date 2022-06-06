using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Medicine
    {
        string name; // more than 3 letters 
        // TODO validate it...
        double price; // only positive numbers
        // TODO validate it...

        // throw ArgumentException("message")

        //TODO constructor Medicine

        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == string.Empty || value.Length < 3) // one check is useless , just a example for empty string
                {
                    throw new ArgumentException("Name has to be at least 3 symbols long!");
                }
                this.name = value;
            }
        }
        public double Price
        {
            get => this.price;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price has to be only positive numbers!");
                }
                this.price = value;
            }
        }

        // TODO method Info for the medicine
        // price need to be 2 digits after the floating point
        public override string ToString()
        {
            return $"Medicine: {Name} with price {Price:f2}";
        }


    }
}
