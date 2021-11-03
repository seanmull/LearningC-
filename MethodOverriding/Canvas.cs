using System.Collections.Generic;

namespace LearningC_.MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                // switch (shape.Type)
                // {
                //     case ShapeType.Circle:
                //         System.Console.WriteLine("Draw a circle");
                //         break;
                
                //     case ShapeType.Rectangle:
                //         System.Console.WriteLine("Draw a rectangle");
                //         break;  
                // }

                shape.Draw();
            }
        }
    }
}