using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp1
{


    class Test
    {
        static void Main(string[] args)
        {
            Compare<int> c = new Compare<int>();
            Console.WriteLine(c.Max(5,13));
          
        }
    }

    class Compare<T> where T : IComparable
    {
        public  T Max(T a,T b) 
        {
            if (a.CompareTo(b) > 0) return a;
            else return b;
        }
    }
   

   



}





