using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        public static void Main()
        {

            var newlist = new BookRepository().GetBooks();
            var price = newlist.Where(b => b.Price > 500).OrderBy(b => b.Title);

            foreach(var book in price)
            {
                Console.WriteLine(book.Price + " " + book.Title);
            }



        }
    }

    public class BookRepository
    {

        public IEnumerable<Book> GetBooks() 
        {
           return new List<Book>()
        {
            new Book() {Title = "NCERT" , Price = 200},
            new Book() {Title = "SCARLET" , Price = 300},
            new Book() {Title = "FLAMINGO" , Price = 200},
            new Book() {Title = "HARRY POTTER" , Price = 700},
            new Book() {Title = "R.D. SHARMA" , Price = 900},
            new Book() {Title = "RS AGGARWAL" , Price = 800},
            new Book() {Title = "CD" , Price = 600},
        };

        }
      
    }
      

}




