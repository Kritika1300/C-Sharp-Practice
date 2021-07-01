using System;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{



    class Program
    {

        static void Main(string[] args)
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            var sqaures = arr1.Where(n => n * n > 20);
            foreach(var num in sqaures)
            {
                Console.WriteLine(num + " sqaure = " + num*num);
            }
        }

    }
}