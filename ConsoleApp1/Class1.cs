using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Test
    {

        public static int Add(int a,int b, int[] arr = null)
        {
            int result = a + b;
            if(arr != null)
            {
                foreach(var i in arr) 
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine(Add(2,3));
        }
    }
}
