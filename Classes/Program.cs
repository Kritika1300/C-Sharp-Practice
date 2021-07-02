using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{


  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-13.php
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1;
            int n, i;

          
            Console.Write("Input number of strings to  store in the array");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            var result = arr1.Aggregate((a, b) => a + "," + b);

           
            Console.WriteLine(result);

        }

    }
}

   
