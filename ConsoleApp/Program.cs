using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //public class Calculate
    //{
    //    public int CalculateMethod(int a, int b, string choice)
    //    {
    //        switch (choice)
    //        {
    //            case "+":
    //                Console.WriteLine(a + b);
    //                return a + b;
                

    //            case "*":
    //                Console.WriteLine(a * b);
    //                return a + b;

    //        }
    //        return 0;
    //    }

    //}  
     
    interface Calculate
    {
        public int CalculateMethod(int a, int b);
    }

    class Add : Calculate
    {
        public int CalculateMethod(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
    }
    class Subtract : Calculate
    {
        public int CalculateMethod(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }
    }
    class HelloWorld
    {
        public static void Main()
        {
            Add a = new Add();
            a.CalculateMethod(5,4);

            Subtract s = new Subtract();
            s.CalculateMethod(5,4);

        }

    }

}







