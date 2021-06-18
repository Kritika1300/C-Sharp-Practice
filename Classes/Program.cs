using System;

namespace Classes
{
     interface IA
    {
        public void Method()
        {
            Console.WriteLine("DEFAULT IMPLEMENTATION");
        }
    }
    
    interface IB
    {
        public void Method();
    }

    class C : IA, IB
    {
      

        void IB.Method()
        {
            Console.WriteLine("Byeeee");
        }
    }

    class Program
    {
        public static void Main()
        {
            C c = new C();
            IA c1 = new C();
            c1.Method();
            ((IB)c).Method();



        }
    }


}