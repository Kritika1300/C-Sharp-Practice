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
            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });

            var task2 = Task.Run(() =>
            {
                return Calculate2();
            });

            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();
            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate3(result1,result2);
  
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

        public static int Calculate3(int result1,int result2)
        {
            Console.WriteLine("Calculate3");
            return result1 + result2;
        }
    }
   
}




