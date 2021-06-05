using System.IO;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
         
        }

    }

}
