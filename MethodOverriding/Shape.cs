namespace LearningC_.MethodOverriding
{
    
    
    public class Circle : Shape
    {
        public override void Draw()
        {
            //Any code specific to the circle itself
            System.Console.WriteLine("Draw a circle");
            //base.Draw();
        }
    }
    
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

//        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }

    }
}

























