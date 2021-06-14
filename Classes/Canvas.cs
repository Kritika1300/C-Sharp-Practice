using System.Collections.Generic;
using System;

namespace Classes
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> list)
        {
            foreach(var shape in list)
            {
                shape.Draw();
            }
        }

    }

}
