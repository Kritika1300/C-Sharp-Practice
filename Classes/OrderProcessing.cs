using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    namespace Classes
    {
        
        abstract class Shape
        {
            public string Color { get; set; }

            public int Size { get; set; }

            public abstract void Draw();

            public abstract double CalculateCost();


        }

        abstract class Circle : Shape
        {

            public override void Draw()
            {
                Console.WriteLine("Drawing circle.....");
            }
        }

        class RedCircle : Circle
        {
            public override double CalculateCost()
            {
                return 3.14;
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                RedCircle r = new RedCircle();
                r.Draw();

            }
        }

    }


}

