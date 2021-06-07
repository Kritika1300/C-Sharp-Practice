using System;

namespace Classes {

    class Program
    {
        static void Main(string[] args)
        {
        eligible:
            Console.WriteLine("You are not eligible to vote");

            Console.WriteLine("Enter your age:");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input < 18)
            {
                goto eligible;
            }
            else
            {
                Console.WriteLine("You are eligible!");
            }
            

        }
    }

}
