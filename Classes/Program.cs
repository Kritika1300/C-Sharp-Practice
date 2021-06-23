using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            IEnumerable<int> numbers = new List<int>() { 1, 28, 6, 5, 67, 0 };
            int max = numbers.Max();
            Console.WriteLine(max);
        }
    }

  

}




