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
            /*var books1 = newlist.SingleOrDefault(b => b.Title == "R.D. SHARMA");*/ //returns reqd value only if there is single instance of object else returns default i.e. null
                                                                                     //var books1 = newlist.First(b => b.Title == "NCERT"); // Variation : FirstOrDefault
            /* var books1 = newlist.Last(b => b.Title == "NCERT"); /*/ /*Variation : LastOrDefault*/
            //var books = newlist.Skip(3).Take(2);
            //foreach (var book in books)
            //  Console.WriteLine(book.Title + " " + book.Price);

        }
    }

    public class BookRepository
    {

        public IEnumerable<Book> GetBooks() 
        {
           return new List<Book>()
        {
            new Book() {Title = "NCERT" , Price = 200},
            new Book() {Title = "NCERT" , Price = 230},
            new Book() {Title = "NCERT" , Price = 600},
            new Book() {Title = "SCARLET" , Price = 300},
            new Book() {Title = "FLAMINGO" , Price = 200},
            new Book() {Title = "HARRY POTTER" , Price = 700},
            new Book() {Title = "RS AGGARWAL" , Price = 800},
            new Book() {Title = "CD" , Price = 600},
        };

        }
      
    }
      

}




