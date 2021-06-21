using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    
       public class GenericDictionary<TKey, TValue> //Multiple parameters in Generics
        { 
            public void Add(TKey key, TValue value)
            {


            }
        
        }


   
    class Program
    {
        public static void Main()
        {
            var book = new Book() { Authorname = "J.K. Rowling", Title = "Harry Potter" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();  WIHOUT USE OF GENERIC LIST
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dict = new GenericDictionary<string,Book>();

      
        }
    }
}
