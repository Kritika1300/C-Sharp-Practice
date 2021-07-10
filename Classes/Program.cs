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
        public delegate int MyDelegate(int[] arr);

        public static int Add(int[] arr)
        {
            arr[0] = 1;
            Console.WriteLine("Add");
            return 0;
        }

        public static int Subtract(int[] arr)
        {
            arr[2] = 5;
            Console.WriteLine("Subtract");
            return 0;
        }

        public static int Multiply(int[] arr)
        {
            arr[1] = 4;
            Console.WriteLine("Multiply");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 0,0,0,0,0 };
            MyDelegate del1 = Add;
            del1 += Subtract;
            del1 += Multiply;
         
            del1(arr);

            foreach(var i in arr)
            {
                Console.Write(i + " ");
            }
        }
       
    
    }            

 }
