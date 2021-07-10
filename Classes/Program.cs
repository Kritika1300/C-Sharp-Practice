using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;



namespace Classes
{
  
    class Program 
    {
      
        static void Main(string[] args)
        {
            int[] arr = { 34, 21, 1, 6, 4 };

            Sorting.BubbleSort(arr, (x,y) => x > y);//Lambda function
            foreach(int i in arr)

            {
                Console.Write(i + " ");
            }

        }
       
    
    }

    public class Sorting 
    {
        public delegate bool MyDelegate(int x, int y);
        public static void BubbleSort(int[] arr,MyDelegate del)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (del(arr[i],arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }



 }
