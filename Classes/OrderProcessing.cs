

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    class Mathematics 
    {
        //public int Add(int a, int b)
        //{
        //    Console.WriteLine(a + b + "int - int");
        //    return a + b;

        //}

        public void Add(int a, double b)
        {
            Console.WriteLine(a + b + " int - double");
        }

        //public void Add(double a, int b)
        //{
        //    Console.WriteLine(a + b + "double - int");
        //}

        public double Add(double a, double b)
        {
            Console.WriteLine(a + b + "double - double");
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.Add(38,5);

        }
    }

}