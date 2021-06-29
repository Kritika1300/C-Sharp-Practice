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

           

            var awaiter1 = task1.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {
                var result1 = awaiter1.GetResult();
                Calculate2(result1);
            });
            
            Calculate3();
  
        }

        public static int Calculate1()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Calculate1");
            return 100;
        }

        public static int Calculate2(int result1)
        {
            Console.WriteLine("Calculate2");
            return result1*200;
        }

        public static int Calculate3()
        {
            Console.WriteLine("Calculate3");
            return 300;
        }
    }
   
}




