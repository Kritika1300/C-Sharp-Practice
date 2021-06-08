using System;

namespace Classes
{
    class Program
    {
        public static void ArmstrongNumber(int num1)
        {
            int n = num1;
            int sum = 0;
            while(n != 0)
            {
                int rem = n % 10;
                sum = sum +( rem * rem * rem);
                n = n / 10;
            }
            if(sum == num1)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong number");
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: \n ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            ArmstrongNumber(num1);

        }
    }
}