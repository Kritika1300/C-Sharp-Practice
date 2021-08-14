using System;
using System.Linq;
using System.Threading;

namespace ConsoleProgram
{

    class Program
    {
        public static void Main()
        {
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            Thread t3 = new Thread(Task3);

            t1.Start();
            t2.Start();
            t3.Start();
       
        }

        public static void Task1()
        {
           Console.WriteLine("Task1 started using Thread t1");
           for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task1 " + i);
            }
            Console.WriteLine("Task1 ended using Thread t1");
        }

        public static void Task2()
        {
            Console.WriteLine("Time consuming task started using Thread t2");
            for (int i = 1; i <=5 ; i++)
            {
                Console.WriteLine("Task2 " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine("Time consuming task ended using Thread t2");
        }

        public static void Task3()
        {
            Console.WriteLine("Task3 started using Thread t3");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task3 " + i);
                Thread.Sleep(50);
            }
            Console.WriteLine("Task3 ended using Thread t3");
        }

        

    }
}

  
