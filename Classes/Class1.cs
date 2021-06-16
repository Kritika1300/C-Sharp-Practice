using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Class1
    {
        public static void Main()
        {
            int i = 123;
            object o = i;
            i = 256;
            o = 234;
            Console.WriteLine(i + " " + o); // i and o are independent of each other, value of i was copied in o


            //We can't type cast a boxed value
            int j = 2567;
            object o1 = j;
            double k = (double)o1; // runtime exeception 
            double l = (double)(int)o1; // first UNBOX then typecast
            Console.WriteLine(k);


            // can't unbox a null obj value
            object o2 = null;
            int s = (int)o2; // Null Reference Exception 

            Console.WriteLine(s);


          




            
        }
        
    }
}
