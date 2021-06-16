using System;

namespace Classes
{

    
    public class A 
    {
        protected int id;
        
    }
    class B : A
    {
    
        public void setId()
        {
            B a = new B();
            a.id = 2300;
            id = 101;
            base.id = 200;
            this.id = 900;
            Console.WriteLine(id);
        }

    }
    class Program
    {
        public static void Main()
        {
            B b1 = new B();
            b1.setId();
          
        }
    }

}

