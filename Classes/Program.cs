using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  
    class Program
    {

        static void Main(string[] args)
        {
            string[] arr = new string[] {"abc", "def", "ghi" };
            string res = arr.Aggregate((a, b) => a + ","+ b);
            Console.WriteLine(res);

            int[] arr1 = new int[] { 1,2,3,4,5 };
            int res1 = arr1.Aggregate((a, b) => a * b);
            Console.WriteLine(res1);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 }; 
            int res2 = arr1.Aggregate(10,(a, b) => a * b);// seed parameter
            Console.WriteLine(res2);

        }

    }
}

   
