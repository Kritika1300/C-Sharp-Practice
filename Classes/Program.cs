using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            SampleDelegate del = new SampleDelegate(Test.SampleMethodOne);
            del += Test.SampleMethodThree;
            del += Test.SampleMethodTwo;
           
            int defaultval = -1;
            del(out defaultval);
            Console.WriteLine(defaultval);
        }
    }

    delegate void SampleDelegate(out int Number);
    class Test
    {
       public static void SampleMethodOne(out int Number)
       {
            Number = 1;
       }

        public static void SampleMethodTwo(out int Number)
        {
            Number = 5;
        }

        public static void SampleMethodThree(out int Number)
        {
            Number = 6;
        }




    }



}

    
        

