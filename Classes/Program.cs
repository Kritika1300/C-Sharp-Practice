﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-4.php
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] arr1 = new int[] { 1,2,3,4,5,2,3,4,5,5,6,1 };
            var res = arr1.Where(num => num%2 ==0).Select((num, index) => new { Number = num, Index = index });
            foreach(var i in res)
            {
                Console.WriteLine(i.Number + " " + i.Index);
            }
            
           
        }

    }
}

   
