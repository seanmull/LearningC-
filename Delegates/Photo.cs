using System;

namespace LearningC_.Delegates
{
    public class Photo
    {
        public Photo()
        {
        }

        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }
}