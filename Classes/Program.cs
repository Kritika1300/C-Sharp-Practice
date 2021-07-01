using System;

namespace Classes
{

   
    public delegate int MyDelegate(int a,int b);

    public delegate void MyDelegate1(string message);
    class Program
    {
        public static void Main()
        {
        

            MyDelegate del = (int a, int b) => { return a + b; };
            int res = del(3,43);
            Console.WriteLine(res);

            MyDelegate1 del1 = delegate (string name)
            {
                Console.WriteLine(name);
            };
            del1("Kritika");

          
        }

    }





}




