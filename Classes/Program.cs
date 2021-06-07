using System;
using System.Linq;

namespace Classes {

    class Program
    {
        public static  int MaxNumber(params int[] arr)
        {
            return arr.Max();
        }
        static void Main(string[] args)
        {
        
            Console.WriteLine(MaxNumber(1,3,4,5,89,90,65));

        }
    }

}
