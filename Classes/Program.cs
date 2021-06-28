using System;
using System.Threading;

namespace Classes
{
    public delegate string PrintHandler(string message);
    class Program
    {

        public static void Main()
        {
            //Thread t1 = new Thread(Numbers.PrintNumbers);  || under the hood threadstart delegate is being used by the framework
            //Thread t1 = new Thread(new ThreadStart(Numbers.PrintNumbers)); ||using ThreadStart
            //Thread t1 = new Thread(delegate () { Numbers.PrintNumbers(); }); || using dleegate keyword
            Thread t1 = new Thread(() => Numbers.PrintNumbers()); //using lambda functions
            t1.Start();

        }

    }

    class Numbers
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i <= 40; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}




