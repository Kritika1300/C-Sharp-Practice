using System;

namespace Classes
{
    class Program
    {
        public static int ReverseNumber(int str)
        {
            int n = str;
            int rev = 0;
            while(n != 0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            return rev;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to Reverse it : \n ");
            var str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ReverseNumber(str));
            
        }
    }
}