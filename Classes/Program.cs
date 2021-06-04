using System.Text;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder();
            str.Append('-', 10).AppendLine().Append("Heyyyyy").AppendLine().Append('-', 10);
            str.Replace('-', '#');
            str.Remove(0, 2);
            str.Insert(0, new string('$', 2));
            Console.WriteLine(str);
        }
    }

}
