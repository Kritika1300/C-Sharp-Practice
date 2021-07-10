using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;



namespace Classes
{
    public delegate bool MyDelegate(int x, int y);
    class Program 
    {
      
        static void Main(string[] args)
        {

            MyDelegate del = new MyDelegate(AscendingSortingLogic);
            int[] arr = { 34, 21, 1, 6, 4 };
            Sorting.BubbleSort(arr,del);
            Sorting.BubbleSort(arr, DescendingSortingLogic);
            foreach(int i in arr)

            {
                Console.Write(i + " ");
            }

        }

        public static bool DescendingSortingLogic(int x, int y)
        {
            return x < y;
        }

        public static bool AscendingSortingLogic(int x, int y)
        {
            return x > y;
        }

    }

    public class Sorting 
    {
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
