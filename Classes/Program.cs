using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{


  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-10.php
    class Program
    {
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(5);
            templist.Add(7);
            templist.Add(13);
            templist.Add(24);
            templist.Add(6);
            templist.Add(9);
            templist.Add(8);
            templist.Add(7);

            var result = templist.Take(3);

            foreach(var num in result)
            {
                Console.WriteLine(num);
            }



        }

    }
}

   
