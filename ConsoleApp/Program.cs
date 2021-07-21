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
            Thread t = new Thread(new ParameterizedThreadStart(Method2));
            t.Start(target);
            Console.WriteLine("Continue with other work.....");
            
            Console.WriteLine("Work1 Ended....");
        }

        public void Method2(object target)
        {
            string t = target.ToString();
            int t1 = int.Parse(t);
            Thread.Sleep(3000);
            for(int i = 0; i <= t1; i++)
            {
                Console.WriteLine("1");
            }
        }
        

    }



}





