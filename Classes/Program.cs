using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-4.php
    class Program
    {
        static void Main(string[] args)
        {
            

            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine().ToLower();
            var res = str.GroupBy(c => c);
            foreach(var character in res) {
                Console.WriteLine(character.Key + " " + character.Count());
            }
           
        }

    }
}

   
