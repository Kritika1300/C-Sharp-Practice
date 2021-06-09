using System;

namespace Classes
{
    class Program
    {
        public static void Calculate(int a, int b, out int[] sum, out int[] product)
        {
            sum = new int[3];
            product = new int[3];
            sum[0] = a + b;
            product[0] = a * b;
        }
        static void Main(string[] args)
        {
            int[] add;
            int[] mul;
            Calculate(2, 3, out add, out mul);
            Console.WriteLine("Addition = {0}, Multiplication = {1}",add[0],mul[0]);
        }
    }
}