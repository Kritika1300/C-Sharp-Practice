using System;
using System.Linq;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            string post = "Hello this is a very very very very very very long blog post";
            var shortenedpost = post.Shorten(10);
            Console.WriteLine(shortenedpost);
        }
    }

    public static class StringExtensions
    {
        public static string Shorten(this String str,int numberOfWords)
        {
            if(numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Enter a number greater than or equal to zero");
            }
            if(numberOfWords == 0)
            {
                return "";
            }
            var words = str.Split(" ");

            if(words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "....";
        }
    }

}




