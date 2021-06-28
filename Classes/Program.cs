using System;
using System.Threading;

namespace Classes
{
    public delegate string PrintHandler(string message);
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Enter target number");
            int target = Convert.ToInt32(Console.ReadLine());
            Numbers n = new Numbers(target);
            Thread t1 = new Thread(n.PrintNumbers);
            t1.Start();
        }

    }

    class Numbers //helper class encapsulating the thread function + data to be passed to the thread
    {
        private int _target; //data to be passed to the thread
        public Numbers(int target) 
        {
            _target = target;
        }
        public void PrintNumbers() //thread function
        {
           
                for (int i = 1; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
            
        }
    }
}




