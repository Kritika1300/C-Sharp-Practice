using System;

namespace Classes
{
    class Program
    {

        static public void Calculate(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int addition = 0;
            int multiplication = 0;

            Calculate(a, b, out addition, out multiplication);

            Console.WriteLine("Sum is = {0} , Product is = {1}",addition,multiplication);
        }
    }
}