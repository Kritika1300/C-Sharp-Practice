using System.Linq;
using System;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(",");
            int[] arr = Array.ConvertAll(input, int.Parse);
            bool flag = false;
            for(int i = 0; i < arr.Length -1 ; i++)
            {
                if (arr[i + 1] != arr[i] + 1)
                {
                    
                    flag = true;
                    break;
                }
            }
            if(flag) Console.WriteLine("Non-consecutive");
            else Console.WriteLine("Consecutive");
        }
      

    }

}
