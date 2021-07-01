using System.Linq;
using System.Collections.Generic;
using System;

namespace Classes
{
    class Program
    {

        public delegate T GenericDelegate<T>(T a, T b);
        public static void Main(string[] args)
        {
            GenericDelegate<int> del1 = new GenericDelegate<int>(AddInt);
            int res1 = del1(3,4);
            Console.WriteLine(res1);

            GenericDelegate<float> del2 = new GenericDelegate<float>(AddFloat);
            float res2 = del2(3.4f, 4);
            Console.WriteLine(res2);

            GenericDelegate<double> del3 = new GenericDelegate<double>(AddDouble);
            double res3 = del3(3.5, 4.5);
            Console.WriteLine(res3);
        }

        public static int AddInt(int a,int b)
        {
            return a + b;
        }

        public static float AddFloat(float a, float b)
        {
            return a + b;
        }

        public static double AddDouble(double a, double b)
        {
            return a + b;
        }

    }

   


}




