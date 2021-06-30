using System.Linq;
using System.Collections.Generic;
//www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-1.php
namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var even = from num in numbers where num % 2 == 0 select num;

            foreach(var e in even)
            {
                System.Console.WriteLine(e);
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




