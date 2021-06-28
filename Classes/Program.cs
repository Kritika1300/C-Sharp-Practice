using System;
using System.Threading;

namespace Classes
{
    public delegate string PrintHandler(string message);
    class Program
    {

        static int total = 0;
        public static void Main()
        {
            Thread t1 = new Thread(Program.AddTen);
            Thread t2 = new Thread(Program.AddTen);
            Thread t3 = new Thread(Program.AddTen);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();
            Console.WriteLine(total);
        }

        public static object _lock = new object();
        public static void AddTen()
        {
           
            for(int i = 1; i <= 50; i++)
            {
                bool isLockAcquired = false;
                Monitor.Enter(_lock, ref isLockAcquired);
                try
                {
                    total++;
                }
                finally
                {
                    if(isLockAcquired)
                       Monitor.Exit(_lock);
                }
            }
        }
    }
   
}




