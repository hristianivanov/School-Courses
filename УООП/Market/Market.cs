using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    static class Market
    {
        //without constructor inplementation
        public static List<Product> Products { get; set; } = new List<Product>();

        public static void Add(string name, string barcode, double price, double amount)
        {
            Product product = new Product(name, barcode, price, amount);
            Products.Add(product);
        }

        public static void Sell(string name,string barcode, double amount)
        {

            bool check = false;
            int index = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Barcode == barcode)
                {
                    check = true;
                    index = i;
                }
            }

            if (check)
            {
                if (Products[index].Amount >= amount)
                {
                    Products[index].Amount -= amount;
                }
            }
            else
            {
                throw new ArgumentException("Not enought quantity");
            }

        }

        public static void Update(string barcode, double amount)
        {

            bool check = false;
            int index = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Barcode == barcode)
                {
                    check = true;
                    index = i;
                }
            }

            if (check)
            {
                Products[index].Amount += amount;
            }
            else
            {
                throw new ArgumentException("Please add your product first!");
            }

        }

        public static void PrintA()
        {
            List<Product> products = Products.OrderBy(x => x.Name).ToList();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} {item.Amount}");
            }
        }

        public static void PrintU()
        {
            List<Product> products = Products.Where(x => x.Amount == 0).ToList();
            products = products.OrderBy(x => x.Name).ToList();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} {item.Amount}");
            }
        }

        public static void PrintD()
        {
            List<Product> products = Products.OrderByDescending(x => x.Amount).ToList();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} {item.Amount}");
            }
        }

        public static double Calculate()
        {
            double sum = 0;
            foreach (var item in Products)
            {
                sum += item.Price;
            }
            return sum ;
        }
    }
}
