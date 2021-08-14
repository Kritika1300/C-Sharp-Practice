using System;
using System.Linq;

namespace ConsoleProgram
{
   
    class Program
    {

        public static void Main()
        {
            int[] arr = { 1, 23, 4, 56, 67, 2, 4, 5 }; 

            var res = arr.Where(num => num % 2 == 0); //Method syntax

            foreach(var number in res)
            {
                Console.Write(number + " ");
               
            }

            Console.WriteLine();

            var res1 = from n in arr where n % 2 != 0 select n; //Query Syntax

            foreach (var number in res1)
            {
                Console.Write(number + " ");
            }

        }
    }

  
}