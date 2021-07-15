using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Test
    {

        public static int Add(int a,int b = 10, int c = 20)
        {
            int result = a + b + c;
            return result;
        }
        static void Main()
        {
            Console.WriteLine(Add(2,c:3)); // a = 2, b = 10, c = 3
            Console.WriteLine(Add(2,3)); // a = 2, b = 3, c = 20
        }
    }
}
