using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dsadasdas");
            Console.Write("Amount of products:");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 1; i <= n; i++)
            {

                List<string> input = Console.ReadLine().Split().ToList();
                Product product = new Product(input[0], input[1], decimal.Parse(input[2]));
                products.Add(product);
            
            }
            Console.Write("Discount:");
            decimal discount = decimal.Parse(Console.ReadLine());
            foreach (var product in products)
            {
                product.Discount(discount);
                Console.WriteLine($"The price of the {product.Name} is {product.Price:f2} lv.");
            }




        }
    }
}
