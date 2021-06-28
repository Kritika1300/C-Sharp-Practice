using System;
using System.Threading;

namespace Classes
{
    public delegate string PrintHandler(string message);
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Enter a number");
            object target = Console.ReadLine();
            //ParameterizedThreadStart pt = new ParameterizedThreadStart(Numbers.PrintNumbers);
            //Thread t1 = new Thread(pt);
            Thread t1 = new Thread(Numbers.PrintNumbers);
            t1.Start(target);
        }

    }

    class Numbers
    {
        public static void PrintNumbers(object target)
        {
            int num = 0;
            if(int.TryParse(target.ToString(),out num))
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}




