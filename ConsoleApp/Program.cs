using System;
using System.Linq;

namespace ConsoleProgram
{

    class Program
    {
        
        delegate int AdditionDelegate(int a, int b); // Delegate definition

        public static int Add(int a,int b) // the function to which AdditionDelegate points
        {
            return a + b;
        }

        public static void Main()
        {
            AdditionDelegate ad = Program.Add; // Instantiation
            int res = ad(3,4); // Invocation
            Console.WriteLine(res);
            ad = Subtract; // Compile time error
        }

        // delegate is type safe function pointer
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

    }
}

  
