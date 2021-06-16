using System;

namespace Classes
{

   
    public class Shape
    {
        protected int x;
        protected int y;

        public Shape(int xpos, int ypos)
        {
            this.x = xpos;
            this.y = ypos;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"SHAPE coordinates : {x} {y}");
        }

    }

    public class Rectangle : Shape
    {

        public Rectangle(int xpos, int ypos) : base(xpos,ypos)
        {

        }
        public new void Draw() // this will not override the base class method just hide it.
        {
            Console.WriteLine($"RECTANGLE coordinates : {x} {y}");
        }
    }


    public class Circle : Shape
    {
        public Circle(int xpos, int ypos) : base(xpos, ypos)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"CIRCLE coordinates : {x} {y}");
        }
    }

    class Program
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(23, 34);
            shapes[1] = new Rectangle(90, 80);
            shapes[2] = new Shape(87, 89);

            foreach (var shape in shapes)
                shape.Draw(); //Polymorphism
 
        }
    }

}

