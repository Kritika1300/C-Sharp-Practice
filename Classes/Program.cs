using System;

namespace Classes
{

     public interface IA
    {
        void MethodA();
    }

    class A : IA
    {
        public void MethodA()
        {
            Console.WriteLine("A");
        }
    }

    public interface IB
    {
        void MethodB();
    }

    class B : IB
    {
        public void MethodB()
        {
            Console.WriteLine("B");
        }
    }

    class C : IA, IB
    {
        A a = new A();
        B b = new B();
        public void MethodA()
        {
            a.MethodA();
        }

        public void MethodB()
        {
            b.MethodB();
        }
    }


    class Program
    {
        public static void Main()
        {

            C c = new C();
            c.MethodA();
            c.MethodB();
            
 
        }
    }

}

