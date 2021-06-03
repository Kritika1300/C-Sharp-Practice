using System;
namespace Classes
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kritika";
            string lastName = "Kaur";

            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            string fullName2 = string.Format("Hey {1} {0}", firstName, lastName);
            Console.WriteLine(fullName2);

            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            string list = string.Join("-", numbers);
            Console.WriteLine(list);

            string verbatim = @"Hey
            Kritika
            checkout this path : c:\Desktop\Practice";
            Console.WriteLine(verbatim);

        }
    }
}
