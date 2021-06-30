using System.Linq;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            var cheapBooks = BookList.GetBooks();
            var cheaperBooks = from book in cheapBooks where book.Price > 10 orderby book.Price descending select book;
            foreach(var book in cheaperBooks)
            {
                System.Console.WriteLine(book.Title + " " + book.Price);
            }
        }



    }

    public class BookList
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>() 
            { 
               new Book() {Title = "NCERT" , Price = 300},
               new Book() {Title = "ULLMAN" , Price = 500},
               new Book() {Title = "R.S. AGGARWAL" , Price = 700},
               new Book() {Title = "R.D. SHARMA" , Price = 600},
               new Book() {Title = "SCARLETT" , Price = 400},
            };

        }

    }


}




