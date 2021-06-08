using System;

namespace Classes
{
    class Program
    {

        static public int Fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            else
            {
                return Fib(n - 2) + Fib(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 1; i <= n; i++)
               Console.WriteLine(Fib(i));
        }
    }
}