using System;

namespace Classes
{
    public abstract class Shape
    {
      public abstract void Draw(); //abstract methods can reside only in abstract classes.

    }

    public class Text : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing shape"); // implementation of abstract method
        }
    }

    public abstract class Text1 : Shape // making derived class abstract allows us to NOT implement the base class abstract method
    {

    }


    public class Program
    {
        public static void Main()
        {
            /*Shape s = new Shape();*/ //abstract class can't be instantiated

            Text t = new Text();
            t.Draw();
        }
    }


}