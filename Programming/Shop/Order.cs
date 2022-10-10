using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
        private static int counter = 0;
        public int OrderID { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public static int OrdersCnt
        {
            get => counter;
            set
            {
                counter = value;
            }
        }

        //•	CreateProduct<име> <цена> - тази команда има за цел да добави продукт с неговото име, цена и базисна стойност за промоционалното поле - false
        //•	CreateProduct<име> <цена> <isOnPromotion>- тази команда има за цел да добави продукт с неговото име, цена и стойност за промоционалното поле


        public Order(int orderNumber, List<Product> productsList)
        {
            this.OrderID = orderNumber;
            this.Products = productsList;
            OrdersCnt++;
        }

        //•	CreateOrder<orderNumber> <ProductName> <ProductName>… - тази команда има за цел
        //да създаде поръчка като в нея трябва да се добавят всички изброени продукти.
        //public static void CreateProduct(string name, double price)
        //{
        //    Product product = new Product(name, price, false);
        //    Products.Add(product);
        //}
        //public static void CreateProduct(string name, double price, bool isOnPromotion)
        //{
        //    Product product = new Product(name, price, isOnPromotion);
        //    Products.Add(product);
        //}


        public static int OrdersCount()
        {
            return OrdersCnt;
        }

        public int OrderNumber()
        {
            return OrderID;

        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double GetOrderTotalPrice()
        {
            return Products.Sum(x => x.Price);
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return 0;
        }

        public double GetDiscountedProductsCount()
        {
            return 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //Order #333333 has the following products:
            //      ### Product -> IphoneX with price 1190.92. On promotion: YES
            //      ### Product -> AirPods with price 149.90. On promotion: NO

            sb.AppendLine($"Order #{OrderID} has the following products:");
            foreach (var item in Products)
            {
                sb.AppendLine($"### Product -> {item.ToString()}");
            }
            return sb.ToString();
        }



    }
}
