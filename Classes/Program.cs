using System;

namespace Classes
{
    class Program
    {
        public static void IsPrime(int num1)
        {
            int i;
            int n = num1;
            for( i = 2; i < num1; i++)
            {
                if(n % i == 0)
                {
                    break;
                }
            }
            if (i == n)
            {
                Console.WriteLine("Prime");
            }

            else
            {
                Console.WriteLine("Not prime");
            }

            }

            static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: \n ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            IsPrime(num1);

        }
    }
}