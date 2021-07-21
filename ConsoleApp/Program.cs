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
            mt.Method1();
        }

    }
    class Multithreading
    {
        public void Method1()
        {
            Console.WriteLine("Started work1....");
            int target = Convert.ToInt32(Console.ReadLine());
            Helper helper = new Helper(target);
            Thread t = new Thread(new ThreadStart(helper.Method2));
            t.Start();
            Console.WriteLine("Continue with other work.....");

            Console.WriteLine("Work1 Ended....");
        }   

    }

    class Helper
    {
        private readonly int _target;
        public Helper(int target)
        {
            _target = target;
        }
        public void Method2()
        {
     
            Thread.Sleep(3000);
            for (int i = 0; i <= _target; i++)
            {
                Console.WriteLine("3");
            }
        }
    }



}





