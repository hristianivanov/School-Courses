using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        private string author;
        private string title;
        private double price;
        public Book(string title, string author, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Author
        {
            get => this.author;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Author can't be empty");
                }
                this.author = value;
            }
        }
        public double Price
        {
            get => this.price;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price can't be negative");
                }
                this.price = value;
            }
        }
        public string Title
        {
            get => this.title;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Title can't be empty");
                }
                this.title = value;
            }
        }

        //метод за намаление на цената с 10% на всички книги с автор Кланси.

        public double Discount()
        {
            
            if (Author == "Кланси" || Author == "Clancy")
            {
                Price = -Price * 0.10;
            }
            return Price;
        }
        //{ автор 1}, { заглавие 1} -> { цена 1}
        public override string ToString()
        {
            return $"{ Author}, { Title} -> { Price:f2}";
        }

    }
}
