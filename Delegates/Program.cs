using System;

namespace LearningC_.Delegates
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     var processor = new Photoprocessor();
        //     var filters = new Photofilter();
        //     Action<Photo> filterHandler = filters.ApplyBrightness; 
        //     filterHandler += filters.ApplyContrast;
        //     filterHandler += filters.ApplyContrast;
        //     processor.Process("photo.jpg", filterHandler);
        // }

        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Apply removeRedEyefilte");
        }
    }
}