using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-7.php
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var res = nums.GroupBy(num => num);
            foreach(var num in res)
            {
                Console.WriteLine(num.Key + " " + num.Key * num.Count() + " " + num.Count());
            }

        }

    }
}

   
