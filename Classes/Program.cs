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
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.WriteLine("Enter starting char");
            char first =(char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("Enter last char");
            char last = (char)Console.Read();

            var res = cities.Where(x => x.StartsWith(first) && x.EndsWith(last));
            foreach(var city in res)
                Console.WriteLine(city);


        }

    }
}

   
