using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            SampleDelegate del = new SampleDelegate(Test.SampleMethodOne);
          
            del += Test.SampleMethodTwo;
            del += Test.SampleMethodThree;
            del -= Test.SampleMethodTwo;
            del();
        }
    }

    delegate void SampleDelegate();
    class Test
    {
       public static void SampleMethodOne()
       {
            Console.WriteLine("SampleMethodOne Invoked");
       }

       public static void SampleMethodTwo()
       {
            Console.WriteLine("SampleMethodTwo Invoked");
       }

       public static void SampleMethodThree()
       {
            Console.WriteLine("SampleMethodThree Invoked");
       }


    }



}

    
        

