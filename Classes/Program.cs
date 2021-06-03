using System;
namespace Classes
{
  
    public class Person1{

        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[5] { 1, 20, 3, 2, 78 };
            var arr2 = new int[9] { 2, 3, 2, 4, 5, 6, 7, 8, 9 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Array.Clear(arr, 0, 2);
            Array.Copy(arr, arr2, 5);
            foreach(var i in arr2)
                Console.WriteLine(i);


        }
    }

}
