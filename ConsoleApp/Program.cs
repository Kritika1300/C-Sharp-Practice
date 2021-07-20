using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{


 
    class Program
    {

        class Shape
        {

        }

        class Circle : Shape
        {
            public void Draw()
            {

            }
        }
        class Car { }

        static void Main(string[] args)
        {
            Shape s = new Circle();
            Circle c = (Circle)s;
            object c1 = s;
            Circle c2 = c1 as Circle;
            if(c2 != null)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            c.Draw();
        }




    }




}