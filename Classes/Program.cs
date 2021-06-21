using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //public T Max<T>(T a, T b)
        //{

        //    /*return a > b ? a : b;*/ // We can't do this because compiler doesn't know type of T and considers both a and b as objects.
        //    // for this we assume that both a and b implement the IComparable Interface which provides a method class CompareTo

        

        //}

        public T Max(T a, T b) // Generic method in Non generic Class
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }


   
    class Program
    {
        public static void Main()
        {
            Utilities<int> u = new Utilities<int>();
         Console.WriteLine(u.Max(20,67));
        }
    }
}
