using System;

namespace Classes
{
    class Program
    {
        public static int SumOfDigits(int str)
        {
            int sum = 0;
            int n = str;
            while( n != 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find Sum Of The Digits : \n ");
            var str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumOfDigits(str));
            
        }
    }
}