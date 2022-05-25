using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Order
    {
        public Order(int orderNumber, string buyer, List<Product> products)
        {
            OrderNumber = orderNumber;
            Buyer = buyer;
            ProductList = products;
        }

        public int OrderNumber { get; set; }
        public string Buyer { get; set; }
        public List<Product> ProductList { get; set; }

        public double Price()
        {

            return ProductList.Sum(x => x.Price * x.Amount);
        }
    }
}
