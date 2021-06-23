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


            var count = newlist.Count();
            Console.WriteLine(count);

            var maxPrice = newlist.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            var minPrice = newlist.Min(b => b.Price);
            Console.WriteLine(minPrice);

            var sum = newlist.Sum(b => b.Price);
            Console.WriteLine(sum);

            var average = newlist.Average(b => b.Price);
            Console.WriteLine(average);





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




