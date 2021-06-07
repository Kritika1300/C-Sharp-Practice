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
            int[][] arr = new int[2][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 1, 2 };

            for(var i = 0; i < arr.Length; i++)
            {
                for(var j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            
       


        }
    }

}
