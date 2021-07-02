using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-9.php
    class Program
    {
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(55);
            templist.Add(200);
            templist.Add(740);
            templist.Add(76);
            templist.Add(230);
            templist.Add(482);
            templist.Add(95);

            var numbers = templist.Where(x => x > 80);
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();

            var res = templist.FindAll(x => x > 200 ? true : false);
            foreach(var number in res)
                Console.WriteLine(number);


        }

    }
}

   
