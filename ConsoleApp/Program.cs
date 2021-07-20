using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool SortingDelegate(int x,int y);
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 93, 5,40,34};
            Sort.BubbleSort(arr, new SortingDelegate(SortingLogic));
            
            foreach(int val in arr)
            {
                Console.Write(val + " ");
            }
           
        }
        public static bool SortingLogic(int x, int y)
        {
            return x < y;
        }

    }

    class Sort
    {
        public static void BubbleSort(int[] arr, SortingDelegate del)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(del(arr[i],arr[j]))
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