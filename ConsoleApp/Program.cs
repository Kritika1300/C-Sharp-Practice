using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] { 1, 2, 34, 5 };
            arr[1] = new int[] { 1, 2 };
            arr[2] = new int[] { 2, 4, 56, 7, 0, 98, 7, 8 };
            arr[3] = new int[] { 2, 4, 56, 7, 0, 98, 7, 8 ,7,8,89};


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }


        }

    
       

    }

  

   
}