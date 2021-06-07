using System;

namespace Classes {

    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = 101;
                int* ptr = &x;
                Console.WriteLine((int)ptr);
            }
            

        }
    }

}
