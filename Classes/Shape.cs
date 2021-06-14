using System;

namespace Classes
{
    public class Shape
    {
        public int width { get; set; }
        public int height { get; set;}

        public virtual void Draw()
        {

        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle drawn");
        }
    }
    public class Rectangle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawn");
        }
    }



}
