using System.Text;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var str = "Kritika";
            var reversed = ReverseName(str);
            Console.WriteLine(reversed);
        }

        static string ReverseName(string str)
        {
            var arr = new char[str.Length];
            for(var i = arr.Length; i > 0; i--)
            {
                arr[arr.Length - i] = str[i - 1];
            }

            return new string(arr);
        }
    }

}
