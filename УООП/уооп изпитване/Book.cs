using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace уооп_изпитване
{
    class Book
    {
        public Book(string title, string author, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Author { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }

        //метод за намаление на цената с 10% на всички книги с автор Кланси.

        public double Discount()
        {
            if (Author == "Кланси")
            {
                Price -= Price * 0.10;
            }
            return Price;
        }
        //{ автор 1}, { заглавие 1} -> { цена 1}
        public override string ToString()
        {
            return $"{Author}, {Title} -> {Price:f2}";
        }

    }
}
