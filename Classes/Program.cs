using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  //www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-6.php
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            var res = arr.Select(days => days);
            foreach(var day in res)
                Console.WriteLine(day);

        }

    }
}

   
