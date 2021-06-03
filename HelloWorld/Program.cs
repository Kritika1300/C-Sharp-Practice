using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit type conversion
            byte b = 255;
            int i = b;
            Console.WriteLine(i);

            //explicit type conversion
            int j = 233;
            byte b1 = (byte)j;
            Console.WriteLine(b1);

            //non-compatible type conversions
            string s = "234";
            int k = int.Parse(s);
            Console.WriteLine(k);


        }
    }
}
