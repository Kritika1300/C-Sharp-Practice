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
           Text text = new Text();
           Shape shape = text; // upcasting

            //text and shape both are references to same object in the memory but they have different views.

            text.width = 100;
            shape.width = 300; 
            Console.WriteLine(text.width); // text.width = 300 as both shape and text point to same object in memory

        }
    }


}
