using System;
using System.Collections.Generic;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //text globalization
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                string input;
                double availability = double.Parse(Console.ReadLine());
                List<Book> bookList = new List<Book>();

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] productInfo = input.Split();

                    bookList.Add(
                        new Book(productInfo[0],
                        productInfo[1],
                        double.Parse(productInfo[2])));

                }

                double sum = 0;
                foreach (var book in bookList)
                {
                    book.Discount();
                    sum += book.Price;
                    Console.WriteLine(book);
                }

                if (availability - sum >= 0)
                {
                    Console.WriteLine("Вие закупихте избраните книги");
                }
                else
                {
                    Console.WriteLine($"Вие не може да закупите избраните книги, защото не ви достигат {sum - availability:f2} лв.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
