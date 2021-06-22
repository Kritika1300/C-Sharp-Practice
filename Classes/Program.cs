using System;
using System.Threading;

namespace Classes
{

    class Program
    {

        public static double Add(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void Main()
        {
            Func<int, float, double, double> del1 = Add;
            double res = del1.Invoke(3, 2, 5); //double res = del1(3, 2, 5); 
            Console.WriteLine(res);
        }
    }
   

}




