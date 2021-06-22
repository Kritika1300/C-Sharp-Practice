using System;
using System.Threading;

namespace Classes
{

    class Program
    {

        public static  void Add(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static void Main()
        {
            Action<int, float, double> del1 = Add;
            del1.Invoke(3, 4, 5);
        }
    }
   

}




