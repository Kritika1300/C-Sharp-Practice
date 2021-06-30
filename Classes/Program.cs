using System.Linq;
using System.Collections.Generic;
//www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-1.php
namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positive = from num in numbers where num >= 1 && num <= 11 select num;

            foreach(var p in positive)
            {
                System.Console.WriteLine(p);
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




