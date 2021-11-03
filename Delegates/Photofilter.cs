using System;

namespace LearningC_.Delegates
{
    public class Photofilter
    {
        public Photofilter()
        {
        }

        internal void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply brightness");;
        }

        internal void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply contrast");
        }

        internal void Resize(Photo photo)
        {
            System.Console.WriteLine("Apply resize");;
        }
    }
}