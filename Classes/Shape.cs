using System;

namespace Classes
{
    public class Shape
    {
        public int width { get; set; }
        public int height { get; set;}

        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
     
    }

    public class Text : Shape
    {
        public int fontSize { get; set; }
        public int fontWeight { get; set; }
    }

    public class Program {
        public static void Main()
        {
            Shape shape = new Text(); // eventhough at compile time shape object is of type Shape, at runtime it is actually of type Text
           /* shape.*/  // -> // here shape will  provide limited view (i.e. no Text class fields/properties)
            Text text = (Text)shape; //downcasting
       

        }
    }


}
