using System;

namespace Classes
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Kritika Kaur      ";
            Console.WriteLine("My name is '{0}'",fullName.Trim());
            Console.WriteLine("My name is '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(firstName+ "\n" + lastName);

            var arr = fullName.Split(' ');
           
            Console.WriteLine(arr[0] + arr[1]);
           

            int num = 1234;
            string str = num.ToString("C0");
            Console.WriteLine(str);




        }
    }

}
