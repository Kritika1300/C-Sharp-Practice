using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    class HelloWorld
    {
        public delegate int MyDelegate(int x, int y);
        
        public static int Add(int a,int b)
        {
            return a + b;
        }

        public static void Main()
        {
            MyDelegate del = delegate (int x, int y) { return x + y; };
            del(2, 3);
        }
    }



}