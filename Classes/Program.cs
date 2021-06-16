
using System;

namespace Classes
{
     
    class Test
    {
       public static float _PI;
       public int radius;

        static Test()
        {
            Console.WriteLine("Static class constructor");
            _PI = 3.14f;
        }
        public Test(int radius)
        {
            Console.WriteLine("Instance class constructor");
            this.radius = radius;
        }

        public float Area()
        {
            return _PI * this.radius * this.radius;
        }
    }
    
   
    
    class Program
    {

        public static void Main()
        {

            Console.WriteLine(Test._PI);

            Test t = new Test(5);
            Console.WriteLine(t.Area());

  

            Test t1 = new Test(6);
            Console.WriteLine(t1.Area());

        }
    }

}

