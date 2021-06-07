using System;
using System.Linq;

namespace Classes {

    class Program
    {
        public static int MaxNumber(int[] arr)
        {
            return arr.Max();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 30, 4, 5 };
            
            Console.WriteLine(MaxNumber(arr));


        }
    }

}
