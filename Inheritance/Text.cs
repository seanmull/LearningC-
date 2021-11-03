namespace LearningC_
{
    public class Text : PresentationObject
    {
       public int FontSize { get; set; }
       public int FontName { get; set; }

       public void  AddHyperline(string url)
       {
           System.Console.WriteLine("We add a link to " + url);
       } 

    //    public static void Main(string[] args)
    //    {
    //        var Text = new Text();
    //        Text.Width = 100;
    //        Text.Copy();
    //        Text.AddHyperline("www.google.com");

    //    }
    }
}