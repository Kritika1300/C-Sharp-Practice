using System.Linq;
using System.Collections.Generic;
//www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-1.php
namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            int[] numbers = { 3, 9, 2, 8, 6, 5 };

            var sqaures = from num in numbers let square = num * num where square > 20  select new { num, square };

            foreach(var s in sqaures)
            {
                System.Console.WriteLine(s);
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




