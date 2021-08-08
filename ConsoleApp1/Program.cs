using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    
class HelloWorld
    {
        static void Main()
        {
            int[] arr = { 5, 3, 2, 1, 1, 4, 3, 3, 3 };
            int answer = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        answer = Math.Max(answer, j - i + 1);
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }


}