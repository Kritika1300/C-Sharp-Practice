using System;
using System.Threading;

namespace Classes
{

    class Program
    {

        //public static bool CheckLength(string str)
        //{
        //    if (str.Length > 5) return true;
        //    else return false;
        //}
        public static void Main()
        {
            Predicate<string> del2 = (str) =>
            {
                if (str.Length > 5) return true;
                else return false;
            };
            //Predicate<string> del1 = CheckLength;
            Console.WriteLine(del2.Invoke("This is a string")); 
        }
    }
   

}




