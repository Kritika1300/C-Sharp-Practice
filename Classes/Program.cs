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
        public void FillCircle()
        {
            Console.WriteLine($"Filling circle with coordiantes : {x} {y}");
        }
    }

    class Program
    {
        public static void Main()
        {
            Shape shape = new Circle(3,4);
            shape. // we can't use FillCircle method using this object

            Circle c = ((Circle)shape).FillCircle; //so we downcast it to Circle type
         
            
 
        }
    }

}

