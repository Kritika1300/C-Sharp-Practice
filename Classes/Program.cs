using System;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        public static void Calculate()
        {
            Task.Run(() =>
            {
                Calculate1();
            });

            Task.Run(() =>
            {
                Calculate2();
            });

            Task.Run(() =>
            {
                Calculate3();
            });
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




