using System;
using System.Collections.Generic;

namespace Classes
{
    class Program {

        public static void Main()
        {
            List<Shape> listofshapes = new List<Shape>();
            Shape shape = new Shape();
            listofshapes.Add(new Circle());
            listofshapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(listofshapes);

        }


    }
}
