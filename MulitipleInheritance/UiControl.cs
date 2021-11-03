namespace LearningC_.MulitipleInheritance
{
    public class TextBox : UiControl
    {

    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            System.Console.WriteLine("Recieved focus");
        }
    }
}