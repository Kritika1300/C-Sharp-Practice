using System;

namespace Classes
{
    class Program
    {
        public static void SwapNumbers(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Numbers after swapping {0} {1}", num1, num2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to swap them : \n ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping {0} {1}",num1,num2);
            SwapNumbers(num1, num2);
            
        }
    }
}