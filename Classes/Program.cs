using System;

namespace Classes
{
  
    class Program
    {
        public static void Main()
        {
            Func<int, int> Square = num => num * num; // lamba exp
            // 1st int for return type, 2nd for arg type
            Console.WriteLine(Square(11));
        }

        //public static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
