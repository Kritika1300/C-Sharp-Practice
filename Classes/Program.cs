using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{

  
    class Program
    {

        static void Main(string[] args)
        {
            

            int[] arr1 = new int[] { 1,2,3,4,5 };
            var res1 = arr1.Select((num, index) => new { Number = num, Index = index }).Where(x => x.Number % 2 == 0).Select(x => x.Index);
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }
           
        }

    }
}

   
