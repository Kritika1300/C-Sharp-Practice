using System.Linq;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            char[] arr = new char[input.Length];

            for(var i = 0; i < input.Length; i++)
            {
                arr[i] = input[i];
            }
            int k = arr.Length - 1;
            for(var j = 0; j < arr.Length && j < k ; j++)
            {
                var temp = arr[j];
                arr[j] = arr[k];
                arr[k] = temp;
                k--;
            }
            Console.WriteLine(string.Join("",arr));
            
        }
      

    }

}
