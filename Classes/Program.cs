using System;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            int factor = 70;
            Func<int, int> Multiplier = n => n * factor;
            Console.WriteLine(Multiplier(4));
        }
    }

        
}

