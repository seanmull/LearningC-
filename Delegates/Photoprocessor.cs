using System;

namespace LearningC_.Delegates
{
    public class Photoprocessor
    {
        // public delegate void PhotoFilterHandler(Photo photo);
        
        internal void Process(string v)
        {
            throw new NotImplementedException();
        }

        // public void Process(string path)
        // {
        //     var photo = Photo.Load(path);

        //     var filters = new Photofilter();
        //     filters.ApplyBrightness(photo);
        //     filters.ApplyContrast(photo);
        //     filters.Resize(photo);

        //     photo.Save();
        // }

        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<>  returns void

            //System.Func<> return something
            var photo = Photo.Load(path);
            
            filterHandler(photo);
                
            photo.Save();
        }
    }
}