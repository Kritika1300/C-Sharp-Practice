using System.Linq;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(",");
            int[] arr = Array.ConvertAll(input, int.Parse);
            int sum = 0;
            int max = arr.Max();

            Console.WriteLine(max);
        }
      

    }

}
