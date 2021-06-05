using System.IO;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type 'Ok' to exit ");
                var input = Console.ReadLine();

               
                if (input == "Ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine(sum);
        }

    }

}
