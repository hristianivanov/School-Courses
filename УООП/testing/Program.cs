using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int orderNum = int.Parse(Console.ReadLine());
            string buyer = Console.ReadLine();
            List<Product> productList = new List<Product>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] productInfo = input
                    .Split(' ');

                productList.Add(
                    new Product(productInfo[0],
                                productInfo[1],
                                double.Parse(productInfo[2]),
                                double.Parse(productInfo[3])));
            }
            Order order = new Order(orderNum, buyer, productList);

            order.Price();

            foreach (var product in order.ProductList)
            {
                product.IncreaseAmount();
                Console.WriteLine(product);
            }
        }
    }
}
