using System;
using System.Linq;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            int i = 2;
            Console.WriteLine(i.Factorial()); 
            
        }
    }

    public static class Int32Extensions
    {
        public static int Factorial(this Int32 x)
        {
            if (x == 0) return 1;
            else if (x == 1 || x == 2) return x;
            else return x * Factorial(x - 1);
        }
    }

}




