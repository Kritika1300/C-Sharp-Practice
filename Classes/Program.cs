using System;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            method2();
            method4();
        }

        public static async void  method2()
        {
            await method3();
            Console.WriteLine("Done");
        }
        public static async Task method3()
        {

             for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("ABC");


            }
            
        }
        public static async Task method4()
        {
            for(int i = 0; i <= 123; i++)
            {
                Console.WriteLine("1000");

            }
            
        }

    }

}




