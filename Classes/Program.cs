using System;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {

        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book() { Title = "Title 1", Price = 7},
                    new Book() { Title = "Title 2", Price = 94},
                    new Book() { Title = "Title 3", Price = 1},

                };
            }
        }
        public static void Main()
        {
            var books = new BookRepository().GetBooks();

            var number = books.FindAll(b => b.Price < 10); //lambda expression Or var number = books.FindAll(IsCheaperThanTen);

            foreach (var i in number)
            {
                Console.WriteLine(i.Title);
            }
        }

        static bool IsCheaperThanTen(Book book)
        {
            return book.Price < 10;
        }
    }

        
}

