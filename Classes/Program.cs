using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(Test.SampleMethodOne);
            del2 = new SampleDelegate(Test.SampleMethodTwo);
            del3 = new SampleDelegate(Test.SampleMethodThree);
            del4 = del1 + del2 + del3 - del1;
            del4();
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

    
        

