using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp1
{


    class Test
    {
        static void Main(string[] args)
        {
            Multithreading mt = new Multithreading();
            Console.WriteLine("Main started");
            Thread t1 = new Thread(mt.Method1);
            t1.Start();
            t1.Join();
            Console.WriteLine("t1 Ended");
            Thread t2 = new Thread(mt.Method2);
            t2.Start();
            t2.Join();
            Console.WriteLine("t2 Ended");
            Console.WriteLine("Main Ended");
        }

    }
    class Multithreading
    {
        public void Method1()
        {
            Console.WriteLine("t1 Started");
            
        }

        public void Method2()
        {
            Console.WriteLine("t2 Started");
        }

    }

   



}





