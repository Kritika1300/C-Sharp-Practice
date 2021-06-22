using System;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {

        public delegate void HelloFunctionDelegate(string message); //A delegate that can point to a function with the same signature i.e. return type void and string parameter

        public static void Main()
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello); // creating instance of the delegate to make it point to a fnc.

            del("Hello from delegate"); // under the hood it calls the Hello function and passes it this string
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

}

    
        

