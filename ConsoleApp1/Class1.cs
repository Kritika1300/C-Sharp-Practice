using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public  class Test
    {
        [Obsolete("USE Add(List<int> list) METHOD",true)]
        public static int Add(int a, int b)
        {
            return a + b;
        }

    
        public static int Add(List<int> list)
        {
            int res = 0;
            foreach(var i in list)
            {
                res += i;
            }
            return res;
        }



        static void Main()
        {
            
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add(new List<int>() { 1, 2, 3, 56, 6, 78, 89 }));
        }
    }
}
