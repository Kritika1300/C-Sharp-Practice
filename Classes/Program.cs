using System;
using System.Threading;

namespace Classes
{
    class Program
    {

        
        public static void Main()
        {
            Calculate();
        }

        public static void Calculate()
        {
            Calculate1();
            Calculate2();
            Calculate3();
        }
        public static int Calculate1()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Calculate1");
            return 100;
        }
        public static int Calculate2()
        {
            Console.WriteLine("Calculate2");
            return 200;
        }
        public static int Calculate3()
        {
            Console.WriteLine("Calculate3");
            return 300;
        }





    }
   
}




