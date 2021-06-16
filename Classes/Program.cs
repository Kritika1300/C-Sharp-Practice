using System;

namespace Classes
{

   
    public class Base
    {
        public void Method1()
        {
            Console.WriteLine("1");
        }

    }

    public class Derived : Base
    {
        public void Method2()
        {
            Console.WriteLine("2");
        }
    }

    //class Program
    //{
    //    public static void Main()
    //    {
    //       Base b = new Derived();
    //       Derived d = (Derived)b;
    //        d.Method1();

    //    }
    //}
    
}

