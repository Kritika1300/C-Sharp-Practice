using System;

namespace Classes
{
    class Program
    {
        public static bool PalindromeCheck(string str)
        {
            bool flag = true;
            var j = str.Length - 1;
            for(var i = 0; i < str.Length && j > i; i++)
            {
                if(str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                j--;
            }
            return flag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string for palindrome check : \n ");
            var str = Console.ReadLine();
            Console.WriteLine(PalindromeCheck(str));
            
        }
    }
}