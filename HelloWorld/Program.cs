using System;

namespace HelloWorld

{
    class Introduce {

        public string firstName;
        public string lastName;
        public  void Name()
        {
            Console.WriteLine("Hey " + firstName + " " + lastName); 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Introduce obj = new Introduce();
            obj.firstName = "Kritika";
            obj.lastName = "Kaur";
            obj.Name();

        }
    }
}
