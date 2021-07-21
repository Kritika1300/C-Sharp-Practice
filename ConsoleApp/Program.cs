using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 8;
            string s = "Factorial is";
            int fact = i.Factorial(s);
            Console.WriteLine(fact);

        }

    }

    public static class Int32Extension 
    {
         public static int Factorial(this Int32 x,string s)
        {
            Console.WriteLine(s);
            if (x == 0) return 1;
            else
            {
                int res = 1;
                for(int i = x; i >  0 ; i--)
                {
                    res = res * i;
                }
               
                return res;
            }
        }
    }

}