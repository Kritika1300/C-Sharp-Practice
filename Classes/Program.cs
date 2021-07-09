using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

enum color : int
{
    red,
    green,
    blue
}

namespace Classes
{

    class A
    {
       
        public  void  abc(float q)
        {
            Console.WriteLine("abc from A");
        }

       
    }

    class B : A
    {
        public  void abc(int p)
        {
            Console.WriteLine("abc from B");
        }

        public void abc(double p)
        {
            Console.WriteLine("abc from B double");
        }

        public void abc(float p)
        {
            Console.WriteLine("abc from B float");
        }


    }

    class C : B
    {
        public void abc(byte q)
        {
            Console.WriteLine("abc from C byte");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            C b = new C();
            b.abc(256.0f);

            Console.ReadLine();
        }
    }

   



}
