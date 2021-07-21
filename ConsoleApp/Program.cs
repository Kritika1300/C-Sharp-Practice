using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp1
{

    class Season
    {

    }
    class Test
    {
        static void Main(string[] args)
        {
            Compare<int> c = new Compare<int>();
            Season s = new Season();
        
            Console.WriteLine(c.CompareStrings(5,4));
          
        }
    }

    class Compare<T> where T : struct
    {
        public bool CompareStrings(T a,T b) 
        {
            bool res = a.Equals(b);
            return res;
        }
    }
   

   



}





